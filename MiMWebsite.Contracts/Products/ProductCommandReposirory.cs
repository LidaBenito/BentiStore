using MiMWebsite.Domains.Products;

namespace MiMWebsite.Contracts.Products
{
	public interface ProductCommandReposirory
	{
		void DeleteProduct(int id);
		Product AddProduct(Product product);
		Product UpdateProduct(Product product);


	}
}
