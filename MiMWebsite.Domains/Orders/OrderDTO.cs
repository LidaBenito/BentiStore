using MiMWebsite.Domains.Categories;
using MiMWebsite.Domains.Products;
using System.Collections.Generic;

namespace MiMWebsite.Domains.Orders
{
	public class OrderDTO
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public List<Category> Categories { get; set; }
		public List<Product> Products { get; set; }
	}
}
