using MiMWebsite.Contracts.Categories;
using MiMWebsite.Domains.Categories;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Categories
{
    public class EFCategoryCommand : CategoryCommandRepository
    {
        private readonly BentiStoreDbContext dbContext;

        public EFCategoryCommand(BentiStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Category Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
