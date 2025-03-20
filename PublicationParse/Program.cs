using Newtonsoft.Json;
using PublicationParse;
using System.Text.RegularExpressions;

async Task MyAsyncFunction()
{
    using Context context = new();

    List<User>? allWorkers = await URLClass.GetWorkersFromUBYSCache();
    if (allWorkers != null)
    {
        List<int> persons = [];
        foreach (User worker in allWorkers)
        {
            int personID = 0;
            string personEncryptedId = string.Empty;
            string? surnameName = null;
            string? title = null, faculty = null, department = null, MSB = null;
            DateTime? startDate = null;
            List<Academicians> academicians = [];
            bool check = false;

            if (worker.KadroKodu == "AKADEMİK")
            {
                personID = worker.PersonId;
                personEncryptedId = worker.PersonEncryptedId!;
                title = worker.AsliUnvan;
                startDate = worker.GoreveBaslamaTarihi;
                surnameName = worker.Soyadi + " " + worker.Adi;
                Academicians? sql = context.Academicians.SingleOrDefault(s => s.PersonID == worker.PersonId);
                if (title != null && title != "" && worker.KurumdanAyrilisTarihi == null)
                {
                    string? academicCV = await URLClass.GetAcademicCVbyAuthor(personEncryptedId);
                    if (academicCV != null)
                    {
                        List<string> palace = AcademicCVParse.WorkingPlaces(academicCV);
                        if (palace.Count >= 3)
                        {
                            faculty = palace[2];
                        }
                        if (palace.Count >= 4)
                        {
                            department = palace[3];
                        }
                        if (palace.Count >= 5)
                        {
                            MSB = palace[4];
                        }
                    }
                    Academicians academic = new()
                    {
                        PersonID = personID,
                        Title = title,
                        Faculty = faculty,
                        Department = department,
                        MSB = MSB,
                        StartDate = startDate,
                        SurnameName = surnameName,
                        PersonEncryptedId = personEncryptedId
                    };
                    persons.Add(personID);
                    if (sql == null)
                    {
                        academicians.Add(academic);
                        context.Academicians.AddRange(academicians);
                        _ = context.SaveChanges();
                    }
                    else if (sql != academic)
                    {
                        sql.PersonID = personID;
                        sql.Title = title;
                        sql.Faculty = faculty;
                        sql.Department = department;
                        sql.MSB = MSB;
                        sql.StartDate = startDate;
                        sql.SurnameName = surnameName;
                        sql.PersonEncryptedId = personEncryptedId;
                        _ = context.SaveChanges();
                    }
                }
                else if (worker.KurumdanAyrilisTarihi != null
                    && sql != null)
                {
                    check = true;
                }
            }
            else if (context.Academicians.SingleOrDefault(s => s.PersonID == worker.PersonId) != null)
            {
                check = true;
            }

            if (check)
            {
                context.Projects.RemoveRange((Projects)context.Projects.Where(s => s.PersonID == worker.PersonId));
                context.Articles.RemoveRange((Articles)context.Articles.Where(s => s.PersonID == worker.PersonId));
                _ = context.Academicians.Remove((Academicians)context.Academicians.Where(s => s.PersonID == worker.PersonId));
                _ = context.SaveChanges();
            }
        }
        context.Projects.RemoveRange(context.Projects.Where(s => !persons.Contains(s.PersonID)).ToList());
        context.Articles.RemoveRange(context.Articles.Where(s => !persons.Contains(s.PersonID)).ToList());
        _ = context.SaveChanges();
        context.Academicians.RemoveRange(context.Academicians.Where(s => !persons.Contains(s.PersonID)).ToList());
        _ = context.SaveChanges();
    }
    else
    {
        Console.WriteLine("Access is Denied for authors.");
    }

    var academics = context.Academicians.Select(s => new { s.PersonID, s.PersonEncryptedId });
    List<Articles> allArticles = [];
    foreach (var aca in academics)
    {
        string? academicCVbyAuthorString = await URLClass.GetAcademicCVbyAuthor(aca.PersonEncryptedId);
        string base64encodedString = AcademicCVParse.GetPublications(academicCVbyAuthorString);
        Base64Decoded? sonuc = JsonConvert.DeserializeObject<Base64Decoded>(base64encodedString);
        if (sonuc.AE_2098001 != null)
        {
            foreach (Article artic in sonuc.AE_2098001)
            {
                string day = "1/";
                string month = artic.AY ?? "1";
                month += "/";
                string year = artic.YIL ?? "1";
                string fullyear = day + month + year;
                DateTime? dt = DateTime.Parse(fullyear);
                Articles articles = new()
                {
                    PersonID = aca.PersonID,
                    ArticleName = artic.MAKALE_ADI,
                    Index = artic.ENDEKS,
                    AuthorNames = artic.YAZAR_ADI,
                    ArticleID = artic.YAYIN_ID != null ? int.Parse(artic.YAYIN_ID) : null,
                    Year = dt,
                    IndexID = artic.ENDEKS_ID != null ? int.Parse(artic.ENDEKS_ID) : null,
                    ScopeID = artic.KAPSAM_ID != null ? int.Parse(artic.KAPSAM_ID) : null,
                    JournalName = artic.DERGI_ADI,
                    CountryName = artic.ULKE_ADI,
                    City = artic.SEHIR,
                    ArticleLangName = artic.YAYIN_DILI_ADI,
                    Issue = artic.SAYI,
                    DOI = artic.DOI,
                    ISSN = artic.ISSN,
                    AccessType = artic.ERISIM_TURU,
                    AccessLink = artic.ERISIM_LINKI,
                    CiteCount = artic.ATIF_SAYISI != null ? int.Parse(artic.ATIF_SAYISI) : null,
                    AreaInfo = artic.ALAN_BILGISI,
                    Keywrds = artic.ANAHTAR_KELIME,
                    TESVPoint = artic.TESV_PUAN,
                    EntityTypeID = artic.EntityTypeId?.ToString(),
                };
                allArticles.Add(articles);
            }
        }
    }
    string pattern = "[^a-zA-Z0-9 ]";
    List<Articles> correctedArticles = [];
    foreach (Articles article in allArticles)
    {
        string articleName = string.Join("", article.ArticleName.Where(x => x != ' '))
            .ToLower().Trim()
            .Replace('ı', 'i')
            .Replace('ğ', 'g')
            .Replace('ş', 's')
            .Replace('ü', 'u')
            .Replace('ö', 'o')
            .Replace('ç', 'c');
        articleName = Regex.Replace(articleName, pattern, "");
        if (!correctedArticles.Any(a => a.ArticleID == article.ArticleID ||
        Regex.Replace(string.Join("", a.ArticleName.Where(x => x != ' '))
        .ToLower().Trim().Replace('ı', 'i').Replace('ğ', 'g').Replace('ş', 's')
        .Replace('ü', 'u').Replace('ö', 'o').Replace('ç', 'c'), pattern, "") == articleName))
        {
            List<string> authorsSplitted = [.. article.AuthorNames.Split(",")];
            article.PersonID = 0;
            bool chk = false;
            foreach (string author in authorsSplitted)
            {
                if (article.Year == null || article.Year < new DateTime(2018, 5, 8))
                {
                    break;
                }
                foreach (Academicians worker in context.Academicians)
                {
                    string workerSurnameandName = worker.SurnameName.ToLower().Trim()
                        .Replace('ı', 'i')
                        .Replace('ğ', 'g')
                        .Replace('ğ', 'g')
                        .Replace('ş', 's')
                        .Replace('ü', 'u')
                        .Replace('ö', 'o')
                        .Replace('ç', 'c');
                    workerSurnameandName = string.Join("", workerSurnameandName.Where(x => x != ' '));
                    string authorSurnameandName = author.ToLower().Trim()
                        .Replace('ı', 'i')
                        .Replace('ğ', 'g')
                        .Replace('ğ', 'g')
                        .Replace('ş', 's')
                        .Replace('ü', 'u')
                        .Replace('ö', 'o')
                        .Replace('ç', 'c');
                    authorSurnameandName = string.Join("", authorSurnameandName.Where(x => x != ' '));
                    if (workerSurnameandName == authorSurnameandName && article.Year >= (worker.StartDate ?? new DateTime(2018, 5, 8)))
                    {
                        article.PersonID = worker.PersonID;
                        correctedArticles.Add(article);
                        chk = true;
                        using Context context2 = new();
                        Articles? t = context2.Articles.SingleOrDefault(s => s.PersonID == article.PersonID && s.ArticleName == article.ArticleName);
                        if (t == null)
                        {
                            _ = context2.Articles.Add(article);
                            _ = context2.SaveChanges();
                        }
                        break;
                    }
                }
                if (chk)
                {
                    break;
                }
            }
        }
    }
}

await MyAsyncFunction();
//Timer timer = new(async _ =>
//{
//    await MyAsyncFunction();
//}, null, TimeSpan.Zero, TimeSpan.FromDays(25));
//await Task.Delay(Timeout.Infinite);