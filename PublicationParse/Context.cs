using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationParse
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=10.10.100.33;Database=TRU_PersonelYayin;User Id=sa;Password=Tru.Bidb.Web.2024.02;TrustServerCertificate=True;");

        public DbSet<UserInfo> Academicians { get; set; }
        public DbSet<DatabaseUser> User { get; set; }
        public DbSet<AE_2098022_Entity> Tasarim { get; set; }
        public DbSet<AE_2098014_Entity> Patentler { get; set; }
        public DbSet<AE_2098013_Entity> SanatsalveMeslekiEtkinlikler { get; set; }
        public DbSet<AE_2098010_Entity> Projeler { get; set; }
        public DbSet<AE_2098009_Entity> YonetilenTezler { get; set; }
        public DbSet<AE_2098006_Entity> Editorlukler { get; set; }
        public DbSet<AE_2098003_Entity> Hakemlik { get; set; }
        public DbSet<AE_2098001_Entity> Makale { get; set; }
        public DbSet<AE_2098001_Entity_Rebuild> MakaleRebuild { get; set; }
        public DbSet<AE_2098004_Entity> Atıflar { get; set; }
        public DbSet<AE_2098002_Entity> Kitaplar { get; set; }
        public DbSet<AE_2098005_Entity> Bildiriler { get; set; }
        public DbSet<AE_2098008_Entity> Oduller { get; set; }
        public DbSet<AE_2098011_Entity> OgretimFaaliyeti { get; set; }
        public DbSet<AE_2098016_Entity> BilimselDanismanliklarveUyelikler { get; set; }
        public DbSet<AE_2098017_Entity> UniversiteDisiDeneyimler { get; set; }
        public DbSet<AE_2098021_Entity> Arastirma { get; set; }
    }
}
