using Microsoft.EntityFrameworkCore;
using MiMWebsite.Contracts.Products;
using MiMWebsite.Domains.Products;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Products
{
    public class EFProductQuery :ProductQueryRepository
    {
        private readonly BentiStoreDbContext dbContext;

        public EFProductQuery(BentiStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Product GetById(int id)=>dbContext.Products.AsNoTracking().
            SingleOrDefault(productId => productId.Id == id);




        public List<Product> GetProducts() => dbContext.Products.AsNoTracking().ToList();
      
    }
}
