using Microsoft.EntityFrameworkCore;
using MiMWebsite.Contracts.Products;
using MiMWebsite.Domains.Products;
using MiMWebsite.Service.Common;
using System;

namespace MiMWebsite.Service.Products
{
	public class EFProductRepository : ProductRepository
	{
        private readonly BenDbcontext dbContext;

        public EFProductRepository(BenDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
		public Product AddProduct(Product product)
		{
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
		}

		public void DeleteProduct(int id)
		{
            var result = dbContext.Products.SingleOrDefault(productId => productId.Id == id);
            dbContext.Products.Remove(result);
            dbContext.SaveChanges();
		}

        public Product GetById(int id)
        {
            var result = dbContext.Products.SingleOrDefault(productId => productId.Id == id);
            return result;
        }

        public Product GetProductByCategoryId(int id)
        {
            var result = dbContext.Products.SingleOrDefault(productId => productId.Category.Id== id);
            return result;

        }

        public List<Product> GetProducts()
        {
            return dbContext.Products.AsNoTracking().ToList();
        }

        public Product UpdateProduct(Product product)
		{
            return dbContext.Products.SingleOrDefault(product);
		}
	}
}
