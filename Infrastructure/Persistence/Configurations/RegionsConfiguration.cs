using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanShop.Domain.Entities;

namespace CleanShop.Infrastructure.Configurations
{
    public class RegionConfiguration : IEntityTypeConfiguration<Regions>
    {
        public void Configure(EntityTypeBuilder<Regions> builder)
        {
            builder.ToTable("Regions");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(r => r.Cities)
                .WithOne(c => c.Regions)
                .HasForeignKey(c => c.RegionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
