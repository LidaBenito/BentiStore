using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiMWebsite.Domains.Products;

namespace MIMWebsite.Services.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(n => n.Name).IsRequired();
            builder.HasIndex(n=>n.Name).IsUnique();
        }
    }
}

