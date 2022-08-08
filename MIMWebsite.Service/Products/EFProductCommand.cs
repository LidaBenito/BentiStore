using AutoMapper;
using MiMWebsite.Contracts.Products;
using MiMWebsite.Domains.Products;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Products
{
    public class EFProductCommand : ProductCommandReposirory
    {
        private readonly BentiStoreDbContext dbContext;
        private readonly IMapper mapper;

        public EFProductCommand(BentiStoreDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public Product AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            var product = dbContext.Products.FirstOrDefault(x => x.Id == id);
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();

        }

        public Product UpdateProduct(Product product)
        {
            Product currentProduct = dbContext.Products.SingleOrDefault(productId => productId.Id == product.Id); 
            if(currentProduct != null)
            {
                mapper.Map(product, currentProduct);
                dbContext.SaveChanges();
                return currentProduct;
            }
            return null;
        }
    }
}
