using Newtonsoft.Json;
using PublicationParse;

//var aktifYazars = await URLClass.GetAktifYazarModelAsync();
//var allWorkers = await URLClass.GetWorkersFromUBYSCache();

//List<UserInfo> userInfos = [];

//int yazarCount = 0;
//foreach (var aktifYazar in aktifYazars)
//{
//    UserInfo userInfo = new()
//    {
//        AuthorId = aktifYazar.Id,
//        PersonId = aktifYazar.PersonId
//    };

//    var personel = allWorkers.FirstOrDefault(s => s.PersonId == aktifYazar.PersonId);

//    userInfo.Title = personel.AsliUnvan;
//    userInfo.KadroUnvan = personel.KadroUnvan;

//    var academicCVbyAuthorString = await URLClass.GetAcademicCVbyAuthor(aktifYazar.Id, aktifYazar.PersonId);

//    var workingPlaces = AcademicCVParse.WorkingPlaces(academicCVbyAuthorString);

//    userInfo.Faculty = null;
//    userInfo.Department = null;
//    userInfo.MSB = null;

//    if (workingPlaces.Count > 3)
//    {
//        userInfo.Faculty = workingPlaces[2];
//        userInfo.Department = workingPlaces[3];
//        userInfo.MSB = workingPlaces[4];
//    }

//    else if (workingPlaces.Count == 3)
//    {
//        userInfo.Faculty = workingPlaces[2];
//    }

//    userInfos.Add(userInfo);

//    Console.WriteLine(userInfo.AuthorId + "-" + userInfo.PersonId + "-" + ++yazarCount);
//}

//using (var context = new Context())
//{
//    context.Academicians.AddRange(userInfos);
//    context.SaveChanges();
//}

//using var context = new Context();
//foreach (var aktifYazar in aktifYazars)
//{
//    var academicCVbyAuthorString = await URLClass.GetAcademicCVbyAuthor(aktifYazar.Id, aktifYazar.PersonId);

//    var base64encodedString = AcademicCVParse.GetPublications(academicCVbyAuthorString);

//    var sonuc = JsonConvert.DeserializeObject<Base64Decoded>(base64encodedString);

//    var academicianId = context.Academicians.FirstOrDefault(s => s.AuthorId == aktifYazar.Id && s.PersonId == aktifYazar.PersonId).Id;

//    if (sonuc.AE_2098001 != null)
//    {
//        List<AE_2098001_Entity> makales = [];
//        foreach (var makale in sonuc.AE_2098001)
//        {
//            AE_2098001_Entity aE_2098001_Entity = new()
//            {
//                AcademicianId = academicianId,
//                YAYIN_ID = makale.YAYIN_ID,
//                KAPSAM_ID = makale.KAPSAM_ID,
//                KAPSAM_AD = makale.KAPSAM_AD,
//                HAKEM_TUR = makale.HAKEM_TUR,
//                HAKEM_TUR_AD = makale.HAKEM_TUR_AD,
//                ENDEKS_ID = makale.ENDEKS_ID,
//                ENDEKS = makale.ENDEKS,
//                MAKALE_ADI = makale.MAKALE_ADI,
//                YAZAR_ADI = makale.YAZAR_ADI,
//                YAZAR_SAYISI = makale.YAZAR_SAYISI,
//                ULKE = makale.ULKE,
//                ULKE_ADI = makale.ULKE_ADI,
//                SEHIR = makale.SEHIR,
//                DERGI_ADI = makale.DERGI_ADI,
//                YAYIN_DILI = makale.YAYIN_DILI,
//                YAYIN_DILI_ADI = makale.YAYIN_DILI_ADI,
//                AY = makale.AY,
//                YIL = makale.YIL,
//                CILT = makale.CILT,
//                SAYI = makale.SAYI,
//                ILK_SAYFA = makale.ILK_SAYFA,
//                SON_SAYFA = makale.SON_SAYFA,
//                DOI = makale.DOI,
//                ISSN = makale.ISSN,
//                ERISIM_TURU = makale.ERISIM_TURU,
//                ERISIM_TURU_AD = makale.ERISIM_TURU_AD,
//                ERISIM_LINKI = makale.ERISIM_LINKI,
//                ATIF_SAYISI = makale.ATIF_SAYISI,
//                ALAN_BILGISI = makale.ALAN_BILGISI,
//                ANAHTAR_KELIME = makale.ANAHTAR_KELIME,
//                OZEL_SAYI = makale.OZEL_SAYI,
//                OZEL_SAYI_AD = makale.OZEL_SAYI_AD,
//                SPONSOR = makale.SPONSOR,
//                YAZAR_ID = makale.YAZAR_ID,
//                GUNCELLEME_TARIHI = makale.GUNCELLEME_TARIHI,
//                AKTIF_PASIF = makale.AKTIF_PASIF,
//                AKTIF_PASIF_AD = makale.AKTIF_PASIF_AD,
//                MAKALE_TURU_ID = makale.MAKALE_TURU_ID,
//                TESV_PUAN = makale.TESV_PUAN,
//                Year = makale.Year,
//                MainText = makale.MainText,
//                EntityTypeId = makale.EntityTypeId,
//                EntityTypeName = makale.EntityTypeName,

//            };

//            makales.Add(aE_2098001_Entity);
//        }

//        context.Makale.AddRange(makales);

//    }

//    if (sonuc.AE_2098010 != null)
//    {
//        List<AE_2098010_Entity> projes = [];
//        foreach (var proje in sonuc.AE_2098010)
//        {
//            AE_2098010_Entity aE_2098010_Entity = new()
//            {
//                AcademicianId = academicianId,
//                PROJE_ID = proje.PROJE_ID,
//                PROJE_AD = proje.PROJE_AD,
//                PROJE_KONUSU = proje.PROJE_KONUSU,
//                PROJE_DURUMU_ID = proje.PROJE_DURUMU_ID,
//                PROJE_DURUMU_AD = proje.PROJE_DURUMU_AD,
//                BAS_TAR = proje.BAS_TAR,
//                BIT_TAR = proje.BIT_TAR,
//                BUTCE = proje.BUTCE,
//                PROJE_KONUMU_ID = proje.PROJE_KONUMU_ID,
//                PROJE_KONUMU_AD = proje.PROJE_KONUMU_AD,
//                PROJE_TURU_ID = proje.PROJE_TURU_ID,
//                PROJE_TURU_AD = proje.PROJE_TURU_AD,
//                PARA_BIRIMI_ID = proje.PARA_BIRIMI_ID,
//                PARA_BIRIMI_AD = proje.PARA_BIRIMI_AD,
//                KAPSAM = proje.KAPSAM,
//                KAPSAM_AD = proje.KAPSAM_AD,
//                UNVAN_ID = proje.UNVAN_ID,
//                UNVAN_AD = proje.UNVAN_AD,
//                KURUM_ID = proje.KURUM_ID,
//                KURUM_AD = proje.KURUM_AD,
//                TESV_PUAN = proje.TESV_PUAN,
//                Year = proje.Year,
//                MainText = proje.MainText,
//                EntityTypeId = proje.EntityTypeId,
//                EntityTypeName = proje.EntityTypeName,
//                GUNCELLEME_TARIHI = proje.GUNCELLEME_TARIHI,
//                AKTIF_PASIF = proje.AKTIF_PASIF,
//                AKTIF_PASIF_AD = proje.AKTIF_PASIF_AD,

//            };

//            projes.Add(aE_2098010_Entity);
//        }

//        context.Projeler.AddRange(projes);
//    }

//    if (sonuc.AE_2098003 != null)
//    {
//        List<AE_2098003_Entity> hakems = [];
//        foreach (var hakem in sonuc.AE_2098003)
//        {
//            AE_2098003_Entity aE_2098003_Entity = new()
//            {
//                AcademicianId = academicianId,
//                YAYIN_ID = hakem.YAYIN_ID,
//                KAPSAM_ID = hakem.KAPSAM_ID,
//                KAPSAM_AD = hakem.KAPSAM_AD,
//                HAKEMLIK_TURU = hakem.HAKEMLIK_TURU,
//                HAKEMLIK_TURU_AD = hakem.HAKEMLIK_TURU_AD,
//                YAYIN_YERI = hakem.YAYIN_YERI,
//                HAKEMLIK_SAYISI = hakem.HAKEMLIK_SAYISI,
//                ULKE = hakem.ULKE,
//                ULKE_ADI = hakem.ULKE_ADI,
//                SEHIR = hakem.SEHIR,
//                YAYIN_DILI = hakem.YAYIN_DILI,
//                YAYIN_DILI_ADI = hakem.YAYIN_DILI_ADI,
//                YIL = hakem.YIL,
//                ALAN_BILGISI = hakem.ALAN_BILGISI,
//                ANAHTAR_KELIME = hakem.ANAHTAR_KELIME,
//                GUNCELLEME_TARIHI = hakem.GUNCELLEME_TARIHI,
//                AKTIF_PASIF = hakem.AKTIF_PASIF,
//                AKTIF_PASIF_AD = hakem.AKTIF_PASIF_AD,
//                TESV_PUAN = hakem.TESV_PUAN,
//                Year = hakem.Year,
//                MainText = hakem.MainText,
//                EntityTypeId = hakem.EntityTypeId,
//                EntityTypeName = hakem.EntityTypeName,
//                ENDEKS_ID = hakem.ENDEKS_ID,
//                ENDEKS = hakem.ENDEKS,

//            };

//            hakems.Add(aE_2098003_Entity);
//        }

//        context.Hakemlik.AddRange(hakems);
//    }

//    if (sonuc.AE_2098002 != null)
//    {
//        List<AE_2098002_Entity> kitaps = [];
//        foreach (var kitap in sonuc.AE_2098002)
//        {
//            AE_2098002_Entity aE_2098002_Entity = new()
//            {
//                AcademicianId = academicianId,
//                YAYIN_ID = kitap.YAYIN_ID,
//                KAPSAM_ID = kitap.KAPSAM_ID,
//                KAPSAM_AD = kitap.KAPSAM_AD,
//                KITAP_TUR_ID = kitap.KITAP_TUR_ID,
//                KITAP_TUR = kitap.KITAP_TUR,
//                KITAP_ADI = kitap.KITAP_ADI,
//                KATKI_DUZEYI = kitap.KATKI_DUZEYI,
//                KATKI_DUZEYI_AD = kitap.KATKI_DUZEYI_AD,
//                BOLUM_ADI = kitap.BOLUM_ADI,
//                YAZAR_ADI = kitap.YAZAR_ADI,
//                YAZAR_SAYISI = kitap.YAZAR_SAYISI,
//                EDITOR_ADI = kitap.EDITOR_ADI,
//                ULKE = kitap.ULKE,
//                ULKE_ADI = kitap.ULKE_ADI,
//                SEHIR = kitap.SEHIR,
//                YAYIN_EVI = kitap.YAYIN_EVI,
//                YAYIN_DILI = kitap.YAYIN_DILI,
//                YAYIN_DILI_ADI = kitap.YAYIN_DILI_ADI,
//                YIL = kitap.YIL,
//                ISBN = kitap.ISBN,
//                KACINCI_BASIM = kitap.KACINCI_BASIM,
//                SAYFA_SAYISI = kitap.SAYFA_SAYISI,
//                BOLUM_ILK_SAYFA = kitap.BOLUM_ILK_SAYFA,
//                BOLUM_SON_SAYFA = kitap.BOLUM_SON_SAYFA,
//                BASIM_TURU = kitap.BASIM_TURU,
//                BASIM_TURU_AD = kitap.BASIM_TURU_AD,
//                ERISIM_LINKI = kitap.ERISIM_LINKI,
//                ATIF_SAYISI = kitap.ATIF_SAYISI,
//                ALAN_BILGISI = kitap.ALAN_BILGISI,
//                ANAHTAR_KELIME = kitap.ANAHTAR_KELIME,
//                YAZAR_ID = kitap.YAZAR_ID,
//                GUNCELLEME_TARIHI = kitap.GUNCELLEME_TARIHI,
//                AKTIF_PASIF = kitap.AKTIF_PASIF,
//                AKTIF_PASIF_AD = kitap.AKTIF_PASIF_AD,
//                TESV_PUAN = kitap.TESV_PUAN,
//                Year = kitap.Year,
//                MainText = kitap.MainText,
//                EntityTypeId = kitap.EntityTypeId,
//                EntityTypeName = kitap.EntityTypeName,

//            };

//            kitaps.Add(aE_2098002_Entity);
//        }

//        context.Kitaplar.AddRange(kitaps);
//    }

//    if (sonuc.AE_2098004 != null)
//    {
//        List<AE_2098004_Entity> atıfs = [];
//        foreach (var atıf in sonuc.AE_2098004)
//        {
//            AE_2098004_Entity aE_2098004_Entity = new()
//            {
//                AcademicianId = academicianId,
//                A_ID = atıf.A_ID,
//                DONEM = atıf.DONEM,
//                TUR = atıf.TUR,
//                TUR_AD = atıf.TUR_AD,
//                ESER_TURU = atıf.ESER_TURU,
//                ESER_ID = atıf.ESER_ID,
//                ULUSLAR_KIT_ATF = atıf.ULUSLAR_KIT_ATF,
//                ULUSAL_KIT_ATF = atıf.ULUSAL_KIT_ATF,
//                SSCI_INDEKS_ATF = atıf.SSCI_INDEKS_ATF,
//                ALAN_INDEKS_ATF = atıf.ALAN_INDEKS_ATF,
//                DIGER_ATIF = atıf.DIGER_ATIF,
//                TESV_PUAN = atıf.TESV_PUAN,
//                GUNCELLEME_TARIHI = atıf.GUNCELLEME_TARIHI,
//                ESCI = atıf.ESCI,
//                BESTECI_ESER = atıf.BESTECI_ESER,
//                GZLSNTULSL = atıf.GZLSNTULSL,
//                LOCAL_ATIF_ADI = atıf.LOCAL_ATIF_ADI,
//                Year = atıf.Year,
//                MainText = atıf.MainText,
//                EntityTypeId = atıf.EntityTypeId,
//                EntityTypeName = atıf.EntityTypeName,
//            };

//            atıfs.Add(aE_2098004_Entity);
//        }

//        context.Atıflar.AddRange(atıfs);
//    }

//    if (sonuc.AE_2098005 != null)
//    {
//        List<AE_2098005_Entity> bildiris = [];
//        foreach (var bildiri in sonuc.AE_2098005)
//        {
//            AE_2098005_Entity aE_2098005_Entity = new()
//            {
//                AcademicianId = academicianId,
//                YAYIN_ID = bildiri.YAYIN_ID,
//                KAPSAM_ID = bildiri.KAPSAM_ID,
//                KAPSAM_AD = bildiri.KAPSAM_AD,
//                BILDIRI_TUR_ID = bildiri.BILDIRI_TUR_ID,
//                BILDIRI_TUR = bildiri.BILDIRI_TUR,
//                BILDIRI_ADI = bildiri.BILDIRI_ADI,
//                YAZAR_ADI = bildiri.YAZAR_ADI,
//                YAZAR_SAYISI = bildiri.YAZAR_SAYISI,
//                ULKE = bildiri.ULKE,
//                ULKE_ADI = bildiri.ULKE_ADI,
//                SEHIR = bildiri.SEHIR,
//                ETKINLIK_ADI = bildiri.ETKINLIK_ADI,
//                YAYIN_DILI = bildiri.YAYIN_DILI,
//                YAYIN_DILI_ADI = bildiri.YAYIN_DILI_ADI,
//                ETKINLIK_BAS_TARIHI = bildiri.ETKINLIK_BAS_TARIHI,
//                ETKINLIK_BIT_TARIHI = bildiri.ETKINLIK_BIT_TARIHI,
//                YAYIN_DURUMU = bildiri.YAYIN_DURUMU,
//                YAYIN_DURUMU_AD = bildiri.YAYIN_DURUMU_AD,
//                BASIM_TARIHI = bildiri.BASIM_TARIHI,
//                CILT = bildiri.CILT,
//                SAYI = bildiri.SAYI,
//                ILK_SAYFA = bildiri.ILK_SAYFA,
//                SON_SAYFA = bildiri.SON_SAYFA,
//                DOI = bildiri.DOI,
//                ISSN = bildiri.ISSN,
//                PRINT_ISBN = bildiri.PRINT_ISBN,
//                SPONSOR = bildiri.SPONSOR,
//                BASIM_TURU = bildiri.BASIM_TURU,
//                BASIM_TURU_AD = bildiri.BASIM_TURU_AD,
//                ERISIM_LINKI = bildiri.ERISIM_LINKI,
//                ATIF_SAYISI = bildiri.ATIF_SAYISI,
//                ALAN_BILGISI = bildiri.ALAN_BILGISI,
//                ANAHTAR_KELIME = bildiri.ANAHTAR_KELIME,
//                OZEL_SAYI_AD = bildiri.OZEL_SAYI_AD,
//                YAZAR_ID = bildiri.YAZAR_ID,
//                OZEL_SAYI = bildiri.OZEL_SAYI,
//                GUNCELLEME_TARIHI = bildiri.GUNCELLEME_TARIHI,
//                AKTIF_PASIF = bildiri.AKTIF_PASIF,
//                AKTIF_PASIF_AD = bildiri.AKTIF_PASIF_AD,
//                TESV_PUAN = bildiri.TESV_PUAN,
//                BILDIRI_SUNUM_TURU = bildiri.BILDIRI_SUNUM_TURU,
//                BILDIRI_SUNUM_TURU_AD = bildiri.BILDIRI_SUNUM_TURU_AD,
//                Year = bildiri.Year,
//                MainText = bildiri.MainText,
//                EntityTypeId = bildiri.EntityTypeId,
//                EntityTypeName = bildiri.EntityTypeName,
//            };

//            bildiris.Add(aE_2098005_Entity);
//        }

//        context.Bildiriler.AddRange(bildiris);
//    }

//    if (sonuc.AE_2098008 != null)
//    {
//        List<AE_2098008_Entity> oduls = [];
//        foreach (var odul in sonuc.AE_2098008)
//        {
//            AE_2098008_Entity aE_2098008_Entity = new()
//            {
//                AcademicianId = academicianId,
//                ODUL_ID = odul.ODUL_ID,
//                ODUL_ADI = odul.ODUL_ADI,
//                ODUL_TARIH = odul.ODUL_TARIH,
//                FAAL_DETAY_ID = odul.FAAL_DETAY_ID,
//                FAAL_DETAY_ADI = odul.FAAL_DETAY_ADI,
//                ODUL_TUR_ID = odul.ODUL_TUR_ID,
//                ODUL_TURU = odul.ODUL_TURU,
//                KURULUS_ADI = odul.KURULUS_ADI,
//                P_UNVAN_ID = odul.P_UNVAN_ID,
//                P_UNVAN_AD = odul.P_UNVAN_AD,
//                P_KURUM_ID = odul.P_KURUM_ID,
//                P_KURUM_AD = odul.P_KURUM_AD,
//                ISYERI_TURU_ID = odul.ISYERI_TURU_ID,
//                ISYERI_TURU_ADI = odul.ISYERI_TURU_ADI,
//                KURUM_ADI = odul.KURUM_ADI,
//                KURUM_ID = odul.KURUM_ID,
//                ULKE_ID = odul.ULKE_ID,
//                ULKE_AD = odul.ULKE_AD,
//                ODUL_ACIKLAMA = odul.ODUL_ACIKLAMA,
//                KISI_SAYISI = odul.KISI_SAYISI,
//                ODUL_KISI_SIRA = odul.ODUL_KISI_SIRA,
//                TESV_PUAN = odul.TESV_PUAN,
//                GUNCELLEME_TARIHI = odul.GUNCELLEME_TARIHI,
//                Year = odul.Year,
//                MainText = odul.MainText,
//                EntityTypeId = odul.EntityTypeId,
//                EntityTypeName = odul.EntityTypeName,
//            };

//            oduls.Add(aE_2098008_Entity);
//        }

//        context.Oduller.AddRange(oduls);
//    }

//    if (sonuc.AE_2098011 != null)
//    {
//        List<AE_2098011_Entity> ogretims = [];
//        foreach (var ogretim in sonuc.AE_2098011)
//        {
//            AE_2098011_Entity aE_2098011_Entity = new()
//            {
//                AcademicianId = academicianId,
//                DERS_ID = ogretim.DERS_ID,
//                DERS_ADI = ogretim.DERS_ADI,
//                OGRENIM_ID = ogretim.OGRENIM_ID,
//                OGRENIM_ADI = ogretim.OGRENIM_ADI,
//                AKADEMIK_YIL_ID = ogretim.AKADEMIK_YIL_ID,
//                AKADEMIK_YIL = ogretim.AKADEMIK_YIL,
//                DIL_ID = ogretim.DIL_ID,
//                DIL_ADI = ogretim.DIL_ADI,
//                DERS_SAATI = ogretim.DERS_SAATI,
//                GUNCELLEME_TARIHI = ogretim.GUNCELLEME_TARIHI,
//                EKLEME_TARIHI = ogretim.EKLEME_TARIHI,
//                AKTIF_PASIF = ogretim.AKTIF_PASIF,
//                AKTIF_PASIF_AD = ogretim.AKTIF_PASIF_AD,
//                Year = ogretim.Year,
//                MainText = ogretim.MainText,
//                EntityTypeId = ogretim.EntityTypeId,
//                EntityTypeName = ogretim.EntityTypeName,

//            };

//            ogretims.Add(aE_2098011_Entity);
//        }

//        context.OgretimFaaliyeti.AddRange(ogretims);
//    }

//    if (sonuc.AE_2098016 != null)
//    {
//        List<AE_2098016_Entity> bilimsels = [];
//        foreach (var bilimsel in sonuc.AE_2098016)
//        {
//            AE_2098016_Entity aE_2098016_Entity = new()
//            {
//                AcademicianId = academicianId,
//                UYELIK_ID = bilimsel.UYELIK_ID,
//                KURULUS_ADI = bilimsel.KURULUS_ADI,
//                BAS_TAR = bilimsel.BAS_TAR,
//                BIT_TAR = bilimsel.BIT_TAR,
//                UYELIK_DURUMU = bilimsel.UYELIK_DURUMU,
//                UYELIK_DURUMU_AD = bilimsel.UYELIK_DURUMU_AD,
//                KURULUS_TURU = bilimsel.KURULUS_TURU,
//                KURULUS_TURU_AD = bilimsel.KURULUS_TURU_AD,
//                GUNCELLEME_TARIHI = bilimsel.GUNCELLEME_TARIHI,
//                AKTIF_PASIF = bilimsel.AKTIF_PASIF,
//                AKTIF_PASIF_AD = bilimsel.AKTIF_PASIF_AD,
//                Year = bilimsel.Year,
//                MainText = bilimsel.MainText,
//                EntityTypeId = bilimsel.EntityTypeId,
//                EntityTypeName = bilimsel.EntityTypeName,

//            };

//            bilimsels.Add(aE_2098016_Entity);
//        }

//        context.BilimselDanismanliklarveUyelikler.AddRange(bilimsels);
//    }

//    if (sonuc.AE_2098017 != null)
//    {
//        List<AE_2098017_Entity> universiteDisis = [];
//        foreach (var universiteDisi in sonuc.AE_2098017)
//        {
//            AE_2098017_Entity aE_2098017_Entity = new()
//            {
//                AcademicianId = academicianId,
//                DENEYIM_ID = universiteDisi.DENEYIM_ID,
//                KURULUS_ADI = universiteDisi.KURULUS_ADI,
//                GOREV_ADI = universiteDisi.GOREV_ADI,
//                BAS_TAR = universiteDisi.BAS_TAR,
//                BIT_TAR = universiteDisi.BIT_TAR,
//                IS_TANIMI = universiteDisi.IS_TANIMI,
//                ISYERI_TUR_ID = universiteDisi.ISYERI_TUR_ID,
//                ISYERI_TUR_AD = universiteDisi.ISYERI_TUR_AD,
//                KURULUS_ID = universiteDisi.KURULUS_ID,
//                CALISMA_DURUMU = universiteDisi.CALISMA_DURUMU,
//                GUNCELLEME_TARIHI = universiteDisi.GUNCELLEME_TARIHI,
//                AKTIF_PASIF = universiteDisi.AKTIF_PASIF,
//                AKTIF_PASIF_AD = universiteDisi.AKTIF_PASIF_AD,
//                Year = universiteDisi.Year,
//                MainText = universiteDisi.MainText,
//                EntityTypeId = universiteDisi.EntityTypeId,
//                EntityTypeName = universiteDisi.EntityTypeName,

//            };

//            universiteDisis.Add(aE_2098017_Entity);
//        }

//        context.UniversiteDisiDeneyimler.AddRange(universiteDisis);
//    }

//    if (sonuc.AE_2098021 != null)
//    {
//        List<AE_2098021_Entity> arastirmas = [];
//        foreach (var arastirma in sonuc.AE_2098021)
//        {
//            AE_2098021_Entity aE_2098021_Entity = new()
//            {
//                AcademicianId = academicianId,
//                S_ID = arastirma.S_ID,
//                TUR_ID = arastirma.TUR_ID,
//                TUR_ADI = arastirma.TUR_ADI,
//                ADI = arastirma.ADI,
//                ICERIK = arastirma.ICERIK,
//                YER = arastirma.YER,
//                KAPSAM = arastirma.KAPSAM,
//                KAPSAM_AD = arastirma.KAPSAM_AD,
//                SURE = arastirma.SURE,
//                BASTAR = arastirma.BASTAR,
//                BITTAR = arastirma.BITTAR,
//                UNVAN_ID = arastirma.UNVAN_ID,
//                UNVAN_AD = arastirma.UNVAN_AD,
//                KURUM_AD = arastirma.KURUM_AD,
//                KURUM_ID = arastirma.KURUM_ID,
//                KISI_SAYISI = arastirma.KISI_SAYISI,
//                ULKE_SEHIR = arastirma.ULKE_SEHIR,
//                GUNCELLEME_TARIHI = arastirma.GUNCELLEME_TARIHI,
//                TESV_PUAN = arastirma.TESV_PUAN,
//                AKTIF_PASIF = arastirma.AKTIF_PASIF,
//                AKTIF_PASIF_AD = arastirma.AKTIF_PASIF_AD,
//                Year = arastirma.Year,
//                MainText = arastirma.MainText,
//                EntityTypeId = arastirma.EntityTypeId,
//                EntityTypeName = arastirma.EntityTypeName,

//            };

//            arastirmas.Add(aE_2098021_Entity);
//        }

//        context.Arastirma.AddRange(arastirmas);
//    }

//}

//context.SaveChanges();

List<AE_2098001_Entity_Rebuild> correctedArticlesList = [];

Article articleClass = new();

using var context = new Context();
var correctedArticles = await articleClass.ArticleCorrection(context);

foreach (var article in correctedArticles)
{
    AE_2098001_Entity_Rebuild aE_2098001_Entity_Rebuild = new()
    {
        AcademicianId = article.AcademicianId,
        YAYIN_ID = article.YAYIN_ID,
        KAPSAM_ID = article.KAPSAM_ID,
        KAPSAM_AD = article.KAPSAM_AD,
        HAKEM_TUR = article.HAKEM_TUR,
        HAKEM_TUR_AD = article.HAKEM_TUR_AD,
        ENDEKS_ID = article.ENDEKS_ID,
        ENDEKS = article.ENDEKS,
        MAKALE_ADI = article.MAKALE_ADI,
        YAZAR_ADI = article.YAZAR_ADI,
        YAZAR_SAYISI = article.YAZAR_SAYISI,
        ULKE = article.ULKE,
        ULKE_ADI = article.ULKE_ADI,
        SEHIR = article.SEHIR,
        DERGI_ADI = article.DERGI_ADI,
        YAYIN_DILI = article.YAYIN_DILI,
        YAYIN_DILI_ADI = article.YAYIN_DILI_ADI,
        AY = article.AY,
        YIL = article.YIL,
        CILT = article.CILT,
        SAYI = article.SAYI,
        ILK_SAYFA = article.ILK_SAYFA,
        SON_SAYFA = article.SON_SAYFA,
        DOI = article.DOI,
        ISSN = article.ISSN,
        ERISIM_TURU = article.ERISIM_TURU,
        ERISIM_TURU_AD = article.ERISIM_TURU_AD,
        ERISIM_LINKI = article.ERISIM_LINKI,
        ATIF_SAYISI = article.ATIF_SAYISI,
        ALAN_BILGISI = article.ALAN_BILGISI,
        ANAHTAR_KELIME = article.ANAHTAR_KELIME,
        OZEL_SAYI = article.OZEL_SAYI,
        OZEL_SAYI_AD = article.OZEL_SAYI_AD,
        SPONSOR = article.SPONSOR,
        YAZAR_ID = article.YAZAR_ID,
        GUNCELLEME_TARIHI = article.GUNCELLEME_TARIHI,
        AKTIF_PASIF = article.AKTIF_PASIF,
        AKTIF_PASIF_AD = article.AKTIF_PASIF_AD,
        MAKALE_TURU_ID = article.MAKALE_TURU_ID,
        TESV_PUAN = article.TESV_PUAN,
        Year = article.Year,
        MainText = article.MainText,
        EntityTypeId = article.EntityTypeId,
        EntityTypeName = article.EntityTypeName,

    };



    correctedArticlesList.Add(aE_2098001_Entity_Rebuild);
}

context.MakaleRebuild.AddRange(correctedArticlesList);

context.SaveChanges();


