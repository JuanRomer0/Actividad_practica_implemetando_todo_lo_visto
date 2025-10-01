using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanShop.Domain.Entities;

namespace CleanShop.Infrastructure.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Countries>
    {
        public void Configure(EntityTypeBuilder<Countries> builder)
        {
            builder.ToTable("Countries");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Code)
                .IsRequired()
                .HasMaxLength(10);

            builder.HasMany(c => c.Regions)
                .WithOne(r => r.Countries)
                .HasForeignKey(r => r.CountryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
