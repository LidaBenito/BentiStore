using MiMWebsite.Contracts.Products;
using MiMWebsite.Domains.Products;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Products
{
    public class EFProductCommand : ProductCommandReposirory
    {
        private readonly BentiStoreDbContext dbContext;

        public EFProductCommand(BentiStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Product AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
