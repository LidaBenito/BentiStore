using MiMWebsite.Domains.Categories;

namespace MiMWebsite.Contracts.Categories
{
	public interface CategoryCommandRepository
	{
		void DeleteCategory(int id);
		Category Add(Category category);
		Category Update(Category category);

	}
}
