using MiMWebsite.Contracts.Products;
using MiMWebsite.Domains.Products;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Products
{
    public class EFProductQuery : ProductQueryRepository
    {
        private readonly BentiStoreDbContext dbContext;

        public EFProductQuery(BentiStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
