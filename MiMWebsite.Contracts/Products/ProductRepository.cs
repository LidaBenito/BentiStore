using MiMWebsite.Domains.Products;
using System.Collections.Generic;

namespace MiMWebsite.Contracts.Products
{
	public interface ProductRepository
	{
		//List<Product> GetProducts();
		//Product GetById(int id);
		//Product GetProductByCategoryId(int id);
		//void DeleteProduct(int id);
		Product AddProduct(Product product);
		//Product UpdateProduct(Product product);


	}
}
