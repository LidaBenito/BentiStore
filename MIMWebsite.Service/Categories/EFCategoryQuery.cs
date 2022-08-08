using MiMWebsite.Contracts.Categories;
using MiMWebsite.Domains.Categories;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Categories
{
    public class EFCategoryQuery : CategoryQueryRepository
    {
        private readonly BentiStoreDbContext dbContext;

        public EFCategoryQuery(BentiStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Category> Categories()
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
    }
}
