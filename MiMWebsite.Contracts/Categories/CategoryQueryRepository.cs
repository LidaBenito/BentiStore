using MiMWebsite.Domains.Categories;
using System.Collections.Generic;

namespace MiMWebsite.Contracts.Categories
{
	public  interface CategoryQueryRepository
	{
		List<Category> Categories();
		Category GetById(int id);
		Category GetByProductId(int id);
	}
}
