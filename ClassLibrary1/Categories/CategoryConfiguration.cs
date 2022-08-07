using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiMWebsite.Domains.Categories;

namespace MIMWebsite.Services.Categories
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(n => n.Name).HasMaxLength(50);
            builder.HasIndex(n => n.Name).IsUnique();
            builder.HasMany(p => p.Products).WithOne(c => c.Category).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
