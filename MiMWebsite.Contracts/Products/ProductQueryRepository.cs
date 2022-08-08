using MiMWebsite.Domains.Products;
using System.Collections.Generic;

namespace MiMWebsite.Contracts.Products
{
	public interface ProductQueryRepository
	{
		List<Product> GetProducts();
		Product GetById(int id);
	}
}
