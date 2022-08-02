using MiMWebsite.Contracts.Products;
using MiMWebsite.Domains.Products;
using System;
using System.Collections.Generic;

namespace MiMWebsite.Infra.Products
{
	public class ProductQuery : ProductQueryRepository
	{
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
