
using Microsoft.EntityFrameworkCore;
using MiMWebsite.Domains.Categories;
using MiMWebsite.Domains.Orders;
using MiMWebsite.Domains.Persons;
using MiMWebsite.Domains.Products;
using System.Reflection;

namespace MiMWebsite.Service.Common
{
    public class BenDbcontext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Order> Orders { get; set; }
        public BenDbcontext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }



    }
}
