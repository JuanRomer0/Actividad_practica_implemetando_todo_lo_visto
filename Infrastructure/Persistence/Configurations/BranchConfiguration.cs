using CleanShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanShop.Infrastructure.Persistence.Configurations
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branches");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.NumberComercial)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(b => b.Address)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(b => b.ContactName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(b => b.Phone)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(b => b.City)
                .WithMany(c => c.Branches)
                .HasForeignKey(b => b.CityId);

            builder.HasOne(b => b.Company)
                .WithMany(c => c.Branches)
                .HasForeignKey(b => b.CompanyId);
        }
    }
}
