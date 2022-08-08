using Microsoft.EntityFrameworkCore;
using MiMWebsite.Domains.Categories;
using MiMWebsite.Domains.Orders;
using MiMWebsite.Domains.Persons;
using MiMWebsite.Domains.Products;
using System.Reflection;

namespace MIMWebsite.Service.Common
{
    public class BentiStoreDbContext : DbContext
    {
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product>  Products{ get; set; }
        public DbSet<Person>  People{ get; set; }
        public DbSet<Order>  Orders{ get; set; }
        public BentiStoreDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
