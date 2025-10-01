using Microsoft.EntityFrameworkCore;
using CleanShop.Domain.Entities;
using CleanShop.Infrastructure.Configurations;

namespace CleanShop.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Regions> Regions { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar las entidades usando la fluent API
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
        }
    }
}
