using System.ComponentModel.DataAnnotations;

namespace PublicationParse
{
    public class User
    {
        public int PersonId { get; set; }
        public string TcNumarasi { get; set; }
        public string Uyruk { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Cinsiyeti { get; set; }
        public string Eposta { get; set; }
        public string TelefonCep { get; set; }
        public string TelefonDahili { get; set; }
        public string TelefonDahiliNumara { get; set; }
        public string Adres { get; set; }
        public string BabaAdi { get; set; }
        public string AnaAdi { get; set; }
        public string DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string KanGrubu { get; set; }
        public string SehitGaziYakini { get; set; }
        public string Asili { get; set; }
        public string CovidBagisik { get; set; }
        public string SonTestZamani { get; set; }
        public string HesDurumu { get; set; }
        public int? PersonelTipiId { get; set; }
        public string PersonelTipi { get; set; }
        public int? GorevYeriId { get; set; }
        public string GorevYeri { get; set; }
        public DateTime? GoreveBaslamaTarihi { get; set; }
        public DateTime? KurumdanAyrilisTarihi { get; set; }
        public int? KadroTipiId { get; set; }
        public string KadroTipi { get; set; }
        public string KadroKodu { get; set; }
        public string IdariGorevler { get; set; }
        public string IliskiliOlduguPozisyonlar { get; set; }
        public string EmekliSicilKodu { get; set; }
        public string UnvanId { get; set; }
        public string AsliUnvan { get; set; }
        public int? EkGosterge { get; set; }
        public int? GorevUnvaniId { get; set; }
        public string GorevUnvan { get; set; }
        public int? KadroUnvanId { get; set; }
        public string KadroUnvan { get; set; }
        public string KurumSicilNo { get; set; }
        public int? UstGorevYeriId { get; set; }
        public string UstGorevYeriAdi { get; set; }
        public string PersonBase64Image { get; set; }
        public int? UstGorevBirimId { get; set; }
        public string UstGorevBirimAdi { get; set; }
        public int? KadroBirimId { get; set; }
        public string KadroBirimi { get; set; }
        public int? KadroUstBirimId { get; set; }
        public string KadroUstBirim { get; set; }
        public bool? Aktif { get; set; }
        public string Username { get; set; }
        public string PersonEncryptedId { get; set; }
        public string PersonBase64ImageModifiedOn { get; set; }
        public string BrutUcret { get; set; }
        public DateTime? SonGuncellemeTarihi { get; set; }
        public string KisiselEPosta { get; set; }
        public string KisiselTelefon { get; set; }
    }

    public class Article
    {
        public string? YAYIN_ID { get; set; }
        public string? KAPSAM_ID { get; set; }
        public string? KAPSAM_AD { get; set; }
        public string? HAKEM_TUR { get; set; }
        public string? HAKEM_TUR_AD { get; set; }
        public string? ENDEKS_ID { get; set; }
        public string? ENDEKS { get; set; }
        public required string MAKALE_ADI { get; set; }
        public string? YAZAR_ADI { get; set; }
        public string? YAZAR_SAYISI { get; set; }
        public string? ULKE { get; set; }
        public string? ULKE_ADI { get; set; }
        public string? SEHIR { get; set; }
        public string? DERGI_ADI { get; set; }
        public string? YAYIN_DILI { get; set; }
        public string? YAYIN_DILI_ADI { get; set; }
        public string? AY { get; set; }
        public string? YIL { get; set; }
        public string? CILT { get; set; }
        public string? SAYI { get; set; }
        public string? ILK_SAYFA { get; set; }
        public string? SON_SAYFA { get; set; }
        public string? DOI { get; set; }
        public string? ISSN { get; set; }
        public string? ERISIM_TURU { get; set; }
        public string? ERISIM_TURU_AD { get; set; }
        public string? ERISIM_LINKI { get; set; }
        public string? ATIF_SAYISI { get; set; }
        public string? ALAN_BILGISI { get; set; }
        public string? ANAHTAR_KELIME { get; set; }
        public string? OZEL_SAYI { get; set; }
        public string? OZEL_SAYI_AD { get; set; }
        public string? SPONSOR { get; set; }
        public string? YAZAR_ID { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? AKTIF_PASIF { get; set; }
        public string? AKTIF_PASIF_AD { get; set; }
        public string? MAKALE_TURU_ID { get; set; }
        public string? MAKALE_TURU_AD { get; set; }
        public string? TESV_PUAN { get; set; }
        public int? Year { get; set; }
        public string? MainText { get; set; }
        public int? EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    } //*/

    public class Base64Decoded
    {
        public Article[]? AE_2098001 { get; set; }
    } // TODO

    public class Academicians
    {
        [Key]
        public int PersonID { get; set; }

        public string? Title { get; set; }

        public string? Faculty { get; set; }

        public string? Department { get; set; }

        public string? MSB { get; set; }

        public DateTime? StartDate { get; set; }

        public string? SurnameName { get; set; }
        public string? PersonEncryptedId { get; set; }
    }
    public class Articles
    {
        public int PersonID { get; set; }

        public string ArticleName { get; set; }

        public string? Index { get; set; }

        public string? AuthorNames { get; set; }

        public int? ArticleID { get; set; }

        public DateTime? Year { get; set; }

        public int? IndexID { get; set; }

        public int? ScopeID { get; set; }

        public string? JournalName { get; set; }

        public string? CountryName { get; set; }

        public string? City { get; set; }

        public string? ArticleLangName { get; set; }

        public string? Issue { get; set; }

        public string? DOI { get; set; }

        public string? ISSN { get; set; }

        public string? AccessType { get; set; }

        public string? AccessLink { get; set; }

        public int? CiteCount { get; set; }

        public string? AreaInfo { get; set; }

        public string? Keywrds { get; set; }

        public string? TESVPoint { get; set; }

        public string? EntityTypeID { get; set; }

    }
    public class Projects
    {
        public int PersonID { get; set; }

        public string ProjectName { get; set; }

        public string? GeneralType { get; set; }

        public string? SubType { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public string? State { get; set; }

        public string? OrganisationBudget { get; set; }

        public string? Budget { get; set; }

    }
}