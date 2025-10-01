using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CleanShop.Domain.Entities;

namespace CleanShop.Infrastructure.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<Cities>
    {
        public void Configure(EntityTypeBuilder<Cities> builder)
        {
            builder.ToTable("Cities");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(c => c.Branches)
                .WithOne(b => b.Cities)
                .HasForeignKey(b => b.CityId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
