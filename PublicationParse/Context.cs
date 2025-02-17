using Microsoft.EntityFrameworkCore;

namespace PublicationParse
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            _ = options.UseSqlServer("Server=10.10.81.23;Database=TRU_BFI_TEST;User Id=emrekardal;Password=Ee159753*;TrustServerCertificate=True;");
        }

        public DbSet<Academicians> Academicians { get; set; }

        public DbSet<Articles> Articles { get; set; }

        public DbSet<Projects> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            _ = mb.Entity<Articles>().HasKey(s => new { s.PersonID, s.ArticleName });
            _ = mb.Entity<Projects>().HasKey(s => new { s.PersonID, s.ProjectName });
        }
    }
}
