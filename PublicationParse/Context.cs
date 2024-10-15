using Microsoft.EntityFrameworkCore;

namespace PublicationParse
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            _ = options.UseSqlServer("Server=DESKTOP-6U6JDPE;Database=BFI;User Id=emrekardal;Password=1;TrustServerCertificate=True;");
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
