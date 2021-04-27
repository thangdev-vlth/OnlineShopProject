using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.SizeId).IsRequired().HasDefaultValue(1);
            builder.Property(x => x.ColorId).IsRequired().HasDefaultValue(1);

            builder.HasOne(x => x.currentSize).WithMany(x => x.Products).HasForeignKey(x => x.SizeId);

            builder.HasOne(x => x.currentColor).WithMany(x => x.Products).HasForeignKey(x => x.ColorId);

        }
    }
}
