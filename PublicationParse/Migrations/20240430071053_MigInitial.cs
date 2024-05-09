using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublicationParse.Migrations
{
    /// <inheritdoc />
    public partial class MigInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KadroUnvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSB = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arastirma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUR_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICERIK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SURE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASTAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BITTAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNVAN_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNVAN_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURUM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURUM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KISI_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE_SEHIR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESV_PUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arastirma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Atıflar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    A_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DONEM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TUR_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESER_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESER_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULUSLAR_KIT_ATF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULUSAL_KIT_ATF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSCI_INDEKS_ATF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALAN_INDEKS_ATF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIGER_ATIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESV_PUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BESTECI_ESER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GZLSNTULSL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOCAL_ATIF_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atıflar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bildiriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YAYIN_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BILDIRI_TUR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BILDIRI_TUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BILDIRI_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEHIR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETKINLIK_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETKINLIK_BAS_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETKINLIK_BIT_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DURUMU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DURUMU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASIM_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CILT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SAYI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ILK_SAYFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SON_SAYFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRINT_ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPONSOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASIM_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASIM_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERISIM_LINKI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATIF_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALAN_BILGISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANAHTAR_KELIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OZEL_SAYI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OZEL_SAYI_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESV_PUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BILDIRI_SUNUM_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BILDIRI_SUNUM_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bildiriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BilimselDanismanliklarveUyelikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UYELIK_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURULUS_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BAS_TAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIT_TAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UYELIK_DURUMU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UYELIK_DURUMU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURULUS_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURULUS_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilimselDanismanliklarveUyelikler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Editorlukler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editorlukler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hakemlik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YAYIN_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAKEMLIK_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAKEMLIK_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_YERI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAKEMLIK_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEHIR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDEKS_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDEKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALAN_BILGISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANAHTAR_KELIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESV_PUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakemlik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YAYIN_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KITAP_TUR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KITAP_TUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KITAP_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KATKI_DUZEYI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KATKI_DUZEYI_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOLUM_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EDITOR_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEHIR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_EVI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KACINCI_BASIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SAYFA_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOLUM_ILK_SAYFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BOLUM_SON_SAYFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASIM_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASIM_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERISIM_LINKI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATIF_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALAN_BILGISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANAHTAR_KELIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESV_PUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YAYIN_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAKEM_TUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAKEM_TUR_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDEKS_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDEKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAKALE_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEHIR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DERGI_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CILT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SAYI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ILK_SAYFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SON_SAYFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERISIM_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERISIM_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERISIM_LINKI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATIF_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALAN_BILGISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANAHTAR_KELIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OZEL_SAYI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OZEL_SAYI_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPONSOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAKALE_TURU_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAKALE_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESV_PUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MakaleRebuild",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YAYIN_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAKEM_TUR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HAKEM_TUR_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDEKS_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ENDEKS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAKALE_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEHIR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DERGI_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAYIN_DILI_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CILT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SAYI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ILK_SAYFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SON_SAYFA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERISIM_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERISIM_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ERISIM_LINKI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ATIF_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALAN_BILGISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ANAHTAR_KELIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OZEL_SAYI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OZEL_SAYI_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SPONSOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YAZAR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAKALE_TURU_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MAKALE_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESV_PUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakaleRebuild", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oduller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ODUL_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ODUL_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ODUL_TARIH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FAAL_DETAY_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FAAL_DETAY_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ODUL_TUR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ODUL_TURU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURULUS_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UNVAN_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_UNVAN_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_KURUM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    P_KURUM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISYERI_TURU_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISYERI_TURU_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURUM_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURUM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ULKE_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ODUL_ACIKLAMA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KISI_SAYISI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ODUL_KISI_SIRA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESV_PUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oduller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgretimFaaliyeti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DERS_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DERS_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OGRENIM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OGRENIM_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKADEMIK_YIL_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKADEMIK_YIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIL_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DIL_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DERS_SAATI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EKLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgretimFaaliyeti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patentler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patentler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PROJE_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_KONUSU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_DURUMU_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_DURUMU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BAS_TAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIT_TAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BUTCE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_KONUMU_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_KONUMU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_TURU_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PROJE_TURU_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARA_BIRIMI_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PARA_BIRIMI_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KAPSAM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNVAN_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNVAN_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURUM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURUM_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TESV_PUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanatsalveMeslekiEtkinlikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanatsalveMeslekiEtkinlikler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasarim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasarim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UniversiteDisiDeneyimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DENEYIM_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURULUS_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GOREV_ADI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BAS_TAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIT_TAR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IS_TANIMI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISYERI_TUR_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISYERI_TUR_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KURULUS_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CALISMA_DURUMU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GUNCELLEME_TARIHI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AKTIF_PASIF_AD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversiteDisiDeneyimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YonetilenTezler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcademicianId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YonetilenTezler", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Academicians");

            migrationBuilder.DropTable(
                name: "Arastirma");

            migrationBuilder.DropTable(
                name: "Atıflar");

            migrationBuilder.DropTable(
                name: "Bildiriler");

            migrationBuilder.DropTable(
                name: "BilimselDanismanliklarveUyelikler");

            migrationBuilder.DropTable(
                name: "Editorlukler");

            migrationBuilder.DropTable(
                name: "Hakemlik");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Makale");

            migrationBuilder.DropTable(
                name: "MakaleRebuild");

            migrationBuilder.DropTable(
                name: "Oduller");

            migrationBuilder.DropTable(
                name: "OgretimFaaliyeti");

            migrationBuilder.DropTable(
                name: "Patentler");

            migrationBuilder.DropTable(
                name: "Projeler");

            migrationBuilder.DropTable(
                name: "SanatsalveMeslekiEtkinlikler");

            migrationBuilder.DropTable(
                name: "Tasarim");

            migrationBuilder.DropTable(
                name: "UniversiteDisiDeneyimler");

            migrationBuilder.DropTable(
                name: "YonetilenTezler");
        }
    }
}
