using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiMWebsite.Domains.Persons;



namespace MIMWebsite.Services.Persons
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.FirstName).HasMaxLength(100);
            builder.Property(p => p.Address).HasMaxLength(300);
            builder.Property(p => p.LastName).IsRequired();
            builder.HasIndex(p => p.Id).IsUnique();
            builder.HasMany(p => p.Products).WithOne(c => c.Person).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
