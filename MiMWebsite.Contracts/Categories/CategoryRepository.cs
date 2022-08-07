using MiMWebsite.Domains.Categories;
using System.Collections.Generic;

namespace MiMWebsite.Contracts.Categories
{
	public interface CategoryRepository
	{
		//List<Category> Categories();
		//Category GetById(int id);
		//Category GetByProductId(int id);
		//void DeleteCategory(int id);
		Category Add(Category category);
		//Category Update(Category category);

	}
}
