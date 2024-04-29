using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Namshi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namshi.Infrastructure.Context.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x =>x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(18, 2)");
            builder.HasOne(x => x.Category).WithMany().HasForeignKey(x => x.CategoryId);
        }
    }
}
