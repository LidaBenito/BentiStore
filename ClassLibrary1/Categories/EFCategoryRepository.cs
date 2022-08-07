using MiMWebsite.Contracts.Categories;
using MiMWebsite.Domains.Categories;
using MiMWebsite.Service.Common;

namespace MiMWebsite.Service.Categories
{
    public class EFCategoryRepository : CategoryRepository
    {
        private readonly BenDbcontext dbContext;

        public EFCategoryRepository(BenDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Category Add(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> Categories()
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetByProductId(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
