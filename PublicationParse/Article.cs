using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PublicationParse
{
    public class Article
    {

        public async Task<List<AE_2098001_Entity>> ArticleCorrection(Context context)
        {
            
            var allAcademicians = context.Academicians.ToList();
            var allArticles = context.Makale.ToList();

            List<AE_2098001_Entity> correctedArticles = [];

            for (int i = 0; i < allArticles.Count; i++)
            {
                var article = allArticles[i];

                var duplicates = FindDuplicates(article, allArticles);

                if (duplicates.Count > 1)
                {
                    var yazars = FindYazars(duplicates[0].YAZAR_ADI);

                    foreach (var yazar in yazars)
                    {
                        var personId = await CheckIfPersonelAndAcademic(yazar);

                        if (personId != null)
                        {
                            var academicianId = allAcademicians.FirstOrDefault(s => s.PersonId == personId).Id;

                            var selectedArticle = duplicates.FirstOrDefault(s => s.AcademicianId == academicianId);

                            if(selectedArticle == null)
                            {
                                continue;
                            }

                            else
                            {
                                var newDuplicates = FindDuplicates(selectedArticle, correctedArticles);

                                if (newDuplicates.Count == 0)
                                {
                                    correctedArticles.Add(selectedArticle);
                                }
                            }

                            break;
                        }
                    }
                }

                else
                {
                    correctedArticles.Add(article);
                }

            }

            return correctedArticles;
        }

        private async Task<int?> CheckIfPersonelAndAcademic(string yazar)
        {
            List<string> yazarSplitted = [.. yazar.Split(' ')];
            string lastName = yazarSplitted[0];
            string firstName = yazarSplitted[^1];

            var allPersonel = await URLClass.GetWorkersFromUBYSCache();

            int? personId = null;
            foreach (var personel in allPersonel)
            {
                if (ContainsIgnoreCaseAndTurkishCharacters(personel.Adi, firstName) && ContainsIgnoreCaseAndTurkishCharacters(personel.Soyadi, lastName) && personel.KadroKodu == "AKADEMİK")
                {
                    personId = personel.PersonId;
                }
            }

            return personId;
        }

        private static List<AE_2098001_Entity> FindDuplicates(AE_2098001_Entity articleParam, List<AE_2098001_Entity> allArticles)
        {
            string newOldMakaleAdi = string.Join("", articleParam.MAKALE_ADI.Where(x => x != ' ')).ToLower();
            string newOldYazarAdi = string.Join("", articleParam.YAZAR_ADI.Where(x => x != ' ')).ToLower();

            List<AE_2098001_Entity> duplicates = [];

            foreach (var article in allArticles)
            {

                string newNewMakaleAdi = string.Join("", article.MAKALE_ADI.Where(x => x != ' ')).ToLower();
                string newNewYazarAdi = string.Join("", article.YAZAR_ADI.Where(x => x != ' ')).ToLower();

                if ((newOldMakaleAdi == newNewMakaleAdi && newOldYazarAdi == newNewYazarAdi) || (articleParam.YAYIN_ID == article.YAYIN_ID))
                {
                    duplicates.Add(article);
                }


            }

            return duplicates;

        }

        private static List<string> FindYazars(string? yazars)
        {
            List<string> yazarsSplitted = [.. yazars.Split(",")];

            return yazarsSplitted;
        }

        static string RemoveTurkishCharacters(string input)
        {
            // Türkçe karakterleri İngilizce karakterlere dönüştürme
            input = input
                .Replace('ı', 'i')
                .Replace('İ', 'I')
                .Replace('ğ', 'g')
                .Replace('Ğ', 'G')
                .Replace('ş', 's')
                .Replace('Ş', 'S')
                .Replace('ü', 'u')
                .Replace('Ü', 'U')
                .Replace('ö', 'o')
                .Replace('Ö', 'O')
                .Replace('ç', 'c')
                .Replace('Ç', 'C');

            return input;
        }

        static bool ContainsIgnoreCaseAndTurkishCharacters(string input, string search)
        {
            // Türkçe karakterleri İngilizce karakterlere dönüştürme
            input = RemoveTurkishCharacters(input);
            search = RemoveTurkishCharacters(search);

            // Büyük-küçük harf duyarsızlığı sağlama
            input = input.ToLower();
            search = search.ToLower();

            // Contains metodu ile kontrol etme
            return input.Contains(search);
        }

    }
}
