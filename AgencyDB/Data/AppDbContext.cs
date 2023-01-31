using AgencyDB.Models;
using Microsoft.EntityFrameworkCore;

namespace AgencyDB.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-8BCT0DK;initial catalog=AgencyDB;Trusted_connection=true;MultipleActiveResultSets=true; TrustServerCertificate=True;");
        }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamNetwork> TeamsNetworks { get; set; }
    }
}
