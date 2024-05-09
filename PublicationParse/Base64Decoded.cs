using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationParse
{

    public class Base64Decoded
    {
        public Personelinfo PersonelInfo { get; set; }
        public PersonSpecialAreasAndKeywords[] PersonSpecialAreasAndKeywords { get; set; }
        public DateTime LastAutoUpdateTime { get; set; }
        public Educationinfo[] EducationInfos { get; set; }
        public Position[] Positions { get; set; }
        public AE_2098001[] AE_2098001 { get; set; }
        public AE_2098002[] AE_2098002 { get; set; }
        public AE_2098003[] AE_2098003 { get; set; }
        public AE_2098004[] AE_2098004 { get; set; }
        public AE_2098005[] AE_2098005 { get; set; }
        public AE_2098006[] AE_2098006 { get; set; }
        public AE_2098008[] AE_2098008 { get; set; }
        public AE_2098009[] AE_2098009 { get; set; }
        public AE_2098010[] AE_2098010 { get; set; }
        public AE_2098011[] AE_2098011 { get; set; }
        public AE_2098013[] AE_2098013 { get; set; }
        public AE_2098014[] AE_2098014 { get; set; }
        public AE_2098016[] AE_2098016 { get; set; }
        public AE_2098017[] AE_2098017 { get; set; }
        public AE_2098021[] AE_2098021 { get; set; }
        public AE_2098022[] AE_2098022 { get; set; }
    }

    public class PersonSpecialAreasAndKeywords
    {
        public int AcadmicEntityTypeId { get; set; }
        public string? AcademicEntityScreenName { get; set; }
        public string?[] EntityRows { get; set; }
        public string? EntityRowDetails { get; set; }
        public string? EntityRowsAsDict { get; set; }
    }


    public class AE_2098022
    {
    }

    public class AE_2098014
    {
    }

    public class AE_2098013
    {
    }

    public class AE_2098010
    {

        public string? PROJE_ID { get; set; }
        public string? PROJE_AD { get; set; }
        public string? PROJE_KONUSU { get; set; }
        public string? PROJE_DURUMU_ID { get; set; }
        public string? PROJE_DURUMU_AD { get; set; }
        public string? BAS_TAR { get; set; }
        public string? BIT_TAR { get; set; }
        public string? BUTCE { get; set; }
        public string? PROJE_KONUMU_ID { get; set; }
        public string? PROJE_KONUMU_AD { get; set; }
        public string? PROJE_TURU_ID { get; set; }
        public string? PROJE_TURU_AD { get; set; }
        public string? PARA_BIRIMI_ID { get; set; }
        public string? PARA_BIRIMI_AD { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? AKTIF_PASIF { get; set; }
        public string? AKTIF_PASIF_AD { get; set; }
        public string? KAPSAM { get; set; }
        public string? KAPSAM_AD { get; set; }
        public string? UNVAN_ID { get; set; }
        public string? UNVAN_AD { get; set; }
        public string? KURUM_ID { get; set; }
        public string? KURUM_AD { get; set; }
        public string? TESV_PUAN { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }

    }

    public class AE_2098009
    {
    }

    public class AE_2098006
    {
    }

    public class AE_2098003
    {
        public string? YAYIN_ID { get; set; }
        public string? KAPSAM_ID { get; set; }
        public string? KAPSAM_AD { get; set; }
        public string? HAKEMLIK_TURU { get; set; }
        public string? HAKEMLIK_TURU_AD { get; set; }
        public string? YAYIN_YERI { get; set; }
        public string? HAKEMLIK_SAYISI { get; set; }
        public string? YAYIN_DILI { get; set; }
        public string? YAYIN_DILI_ADI { get; set; }
        public string? ULKE { get; set; }
        public string? ULKE_ADI { get; set; }
        public string? SEHIR { get; set; }
        public string? ENDEKS_ID { get; set; }
        public string? ENDEKS { get; set; }
        public string? ALAN_BILGISI { get; set; }
        public string? ANAHTAR_KELIME { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? AKTIF_PASIF { get; set; }
        public string? AKTIF_PASIF_AD { get; set; }
        public string? YIL { get; set; }
        public string? TESV_PUAN { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }

    }

    public class Personelinfo
    {
        public string? Image { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Unit { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PersonalWebSite { get; set; }
    }

    public class Educationinfo
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int EducationLevelId { get; set; }
        public int EducationLevel { get; set; }
        public string? EducationTypeId { get; set; }
        public DateTime? GraduationDate { get; set; }
        public string? SchoolName { get; set; }
        public string? BranchName { get; set; }
        public string? HigherEducationId { get; set; }
        public HigherEducation HigherEducation { get; set; }
        public string? DiplomaTitleId { get; set; }
        public bool IsAbroad { get; set; }
        public bool HasPrepClass { get; set; }
        public int YearsOfStudy { get; set; }
        public string? DateOfEquivalence { get; set; }
        public string? SchoolOfEquivalence { get; set; }
        public string? BranchOfEquivalence { get; set; }
        public int? HITAPRecordNo { get; set; }
        public string? DateOfSubmission { get; set; }
        public bool IsFirstEducationLevelAtJobStart { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class HigherEducation
    {

        public int Id { get; set; }
        public string? UniversityCode { get; set; }
        public string? InstituteCode { get; set; }
        public string? FacultyCode { get; set; }
        public string? DepartmentCode { get; set; }
        public string? MajorFieldOfStudy { get; set; }
        public string? FieldOfStudy { get; set; }
        public string? Name { get; set; }
        public string? CountryId { get; set; }
        public string? StateId { get; set; }
        public bool IsEducational { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public string? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeletedOn { get; set; }
        public string? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }

    }

    public class Position
    {
        public int PersonPositionId { get; set; }
        public int PersonId { get; set; }
        public string? PersonTitleId { get; set; }
        public string? PersonTitleName { get; set; }
        public int PositionId { get; set; }
        public string? PersonName { get; set; }
        public string? PersonSurname { get; set; }
        public string? PositionName { get; set; }
        public int UnitId { get; set; }
        public string? UnitName { get; set; }
        public bool ByProxy { get; set; }
        public int SurrgatePersonId { get; set; }
        public string? SurrgatePersonName { get; set; }
        public string? SurrgatePersonSurname { get; set; }
        public bool PositionIsDelegate { get; set; }
        public DateTime? StartsOn { get; set; }
        public DateTime? EndsOn { get; set; }
        public string? SurrogateStartsOn { get; set; }
        public string? SurrogateEndsOn { get; set; }
        public int JobId { get; set; }
    }

    public class AE_2098001
    {
        public string? YAYIN_ID { get; set; }
        public string? KAPSAM_ID { get; set; }
        public string? KAPSAM_AD { get; set; }
        public string? HAKEM_TUR { get; set; }
        public string? HAKEM_TUR_AD { get; set; }
        public string? ENDEKS_ID { get; set; }
        public string? ENDEKS { get; set; }
        public string? MAKALE_ADI { get; set; }
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
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    }

    public class AE_2098002
    {
        public string? YAYIN_ID { get; set; }
        public string? KAPSAM_ID { get; set; }
        public string? KAPSAM_AD { get; set; }
        public string? KITAP_TUR_ID { get; set; }
        public string? KITAP_TUR { get; set; }
        public string? KITAP_ADI { get; set; }
        public string? KATKI_DUZEYI { get; set; }
        public string? KATKI_DUZEYI_AD { get; set; }
        public string? BOLUM_ADI { get; set; }
        public string? YAZAR_ADI { get; set; }
        public string? YAZAR_SAYISI { get; set; }
        public string? EDITOR_ADI { get; set; }
        public string? ULKE { get; set; }
        public string? ULKE_ADI { get; set; }
        public string? SEHIR { get; set; }
        public string? YAYIN_EVI { get; set; }
        public string? YAYIN_DILI { get; set; }
        public string? YAYIN_DILI_ADI { get; set; }
        public string? YIL { get; set; }
        public string? ISBN { get; set; }
        public string? KACINCI_BASIM { get; set; }
        public string? SAYFA_SAYISI { get; set; }
        public string? BOLUM_ILK_SAYFA { get; set; }
        public string? BOLUM_SON_SAYFA { get; set; }
        public string? BASIM_TURU { get; set; }
        public string? BASIM_TURU_AD { get; set; }
        public string? ERISIM_LINKI { get; set; }
        public string? ATIF_SAYISI { get; set; }
        public string? ALAN_BILGISI { get; set; }
        public string? ANAHTAR_KELIME { get; set; }
        public string? YAZAR_ID { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? AKTIF_PASIF { get; set; }
        public string? AKTIF_PASIF_AD { get; set; }
        public string? TESV_PUAN { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    }

    public class AE_2098004
    {
        public string? A_ID { get; set; }
        public string? DONEM { get; set; }
        public string? TUR { get; set; }
        public string? TUR_AD { get; set; }
        public string? ESER_TURU { get; set; }
        public string? ESER_ID { get; set; }
        public string? ULUSLAR_KIT_ATF { get; set; }
        public string? ULUSAL_KIT_ATF { get; set; }
        public string? SSCI_INDEKS_ATF { get; set; }
        public string? ALAN_INDEKS_ATF { get; set; }
        public string? DIGER_ATIF { get; set; }
        public string? TESV_PUAN { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? ESCI { get; set; }
        public string? BESTECI_ESER { get; set; }
        public string? GZLSNTULSL { get; set; }
        public string? LOCAL_ATIF_ADI { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    }

    public class AE_2098005
    {
        public string? YAYIN_ID { get; set; }
        public string? KAPSAM_ID { get; set; }
        public string? KAPSAM_AD { get; set; }
        public string? BILDIRI_TUR_ID { get; set; }
        public string? BILDIRI_TUR { get; set; }
        public string? BILDIRI_ADI { get; set; }
        public string? YAZAR_ADI { get; set; }
        public string? YAZAR_SAYISI { get; set; }
        public string? ULKE { get; set; }
        public string? ULKE_ADI { get; set; }
        public string? SEHIR { get; set; }
        public string? ETKINLIK_ADI { get; set; }
        public string? YAYIN_DILI { get; set; }
        public string? YAYIN_DILI_ADI { get; set; }
        public string? ETKINLIK_BAS_TARIHI { get; set; }
        public string? ETKINLIK_BIT_TARIHI { get; set; }
        public string? YAYIN_DURUMU { get; set; }
        public string? YAYIN_DURUMU_AD { get; set; }
        public string? BASIM_TARIHI { get; set; }
        public string? CILT { get; set; }
        public string? SAYI { get; set; }
        public string? ILK_SAYFA { get; set; }
        public string? SON_SAYFA { get; set; }
        public string? DOI { get; set; }
        public string? ISSN { get; set; }
        public string? PRINT_ISBN { get; set; }
        public string? SPONSOR { get; set; }
        public string? BASIM_TURU { get; set; }
        public string? BASIM_TURU_AD { get; set; }
        public string? ERISIM_LINKI { get; set; }
        public string? ATIF_SAYISI { get; set; }
        public string? ALAN_BILGISI { get; set; }
        public string? ANAHTAR_KELIME { get; set; }
        public string? OZEL_SAYI { get; set; }
        public string? OZEL_SAYI_AD { get; set; }
        public string? YAZAR_ID { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? AKTIF_PASIF { get; set; }
        public string? AKTIF_PASIF_AD { get; set; }
        public string? TESV_PUAN { get; set; }
        public string? BILDIRI_SUNUM_TURU { get; set; }
        public string? BILDIRI_SUNUM_TURU_AD { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    }

    public class AE_2098008
    {
        public string? ODUL_ID { get; set; }
        public string? ODUL_ADI { get; set; }
        public string? ODUL_TARIH { get; set; }
        public string? FAAL_DETAY_ID { get; set; }
        public string? FAAL_DETAY_ADI { get; set; }
        public string? ODUL_TUR_ID { get; set; }
        public string? ODUL_TURU { get; set; }
        public string? KURULUS_ADI { get; set; }
        public string? P_UNVAN_ID { get; set; }
        public string? P_UNVAN_AD { get; set; }
        public string? P_KURUM_ID { get; set; }
        public string? P_KURUM_AD { get; set; }
        public string? ISYERI_TURU_ID { get; set; }
        public string? ISYERI_TURU_ADI { get; set; }
        public string? KURUM_ADI { get; set; }
        public string? KURUM_ID { get; set; }
        public string? ULKE_ID { get; set; }
        public string? ULKE_AD { get; set; }
        public string? ODUL_ACIKLAMA { get; set; }
        public string? KISI_SAYISI { get; set; }
        public string? ODUL_KISI_SIRA { get; set; }
        public string? TESV_PUAN { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    }

    public class AE_2098011
    {
        public string? DERS_ID { get; set; }
        public string? DERS_ADI { get; set; }
        public string? OGRENIM_ID { get; set; }
        public string? OGRENIM_ADI { get; set; }
        public string? AKADEMIK_YIL_ID { get; set; }
        public string? AKADEMIK_YIL { get; set; }
        public string? DIL_ID { get; set; }
        public string? DIL_ADI { get; set; }
        public string? DERS_SAATI { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? EKLEME_TARIHI { get; set; }
        public string? AKTIF_PASIF { get; set; }
        public string? AKTIF_PASIF_AD { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    }

    public class AE_2098016
    {
        public string? UYELIK_ID { get; set; }
        public string? KURULUS_ADI { get; set; }
        public string? BAS_TAR { get; set; }
        public string? BIT_TAR { get; set; }
        public string? UYELIK_DURUMU { get; set; }
        public string? UYELIK_DURUMU_AD { get; set; }
        public string? KURULUS_TURU { get; set; }
        public string? KURULUS_TURU_AD { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? AKTIF_PASIF { get; set; }
        public string? AKTIF_PASIF_AD { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    }

    public class AE_2098017
    {
        public string? DENEYIM_ID { get; set; }
        public string? KURULUS_ADI { get; set; }
        public string? GOREV_ADI { get; set; }
        public string? BAS_TAR { get; set; }
        public string? BIT_TAR { get; set; }
        public string? IS_TANIMI { get; set; }
        public string? ISYERI_TUR_ID { get; set; }
        public string? ISYERI_TUR_AD { get; set; }
        public string? KURULUS_ID { get; set; }
        public string? CALISMA_DURUMU { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? AKTIF_PASIF { get; set; }
        public string? AKTIF_PASIF_AD { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    }

    public class AE_2098021
    {
        public string? S_ID { get; set; }
        public string? TUR_ID { get; set; }
        public string? TUR_ADI { get; set; }
        public string? ADI { get; set; }
        public string? ICERIK { get; set; }
        public string? YER { get; set; }
        public string? KAPSAM { get; set; }
        public string? KAPSAM_AD { get; set; }
        public string? SURE { get; set; }
        public string? BASTAR { get; set; }
        public string? BITTAR { get; set; }
        public string? UNVAN_ID { get; set; }
        public string? UNVAN_AD { get; set; }
        public string? KURUM_AD { get; set; }
        public string? KURUM_ID { get; set; }
        public string? KISI_SAYISI { get; set; }
        public string? ULKE_SEHIR { get; set; }
        public string? GUNCELLEME_TARIHI { get; set; }
        public string? TESV_PUAN { get; set; }
        public string? AKTIF_PASIF { get; set; }
        public string? AKTIF_PASIF_AD { get; set; }
        public int Year { get; set; }
        public string? MainText { get; set; }
        public int EntityTypeId { get; set; }
        public string? EntityTypeName { get; set; }
    }

}
