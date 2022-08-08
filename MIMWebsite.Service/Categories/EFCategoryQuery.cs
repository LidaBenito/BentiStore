using Microsoft.EntityFrameworkCore;
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
        public List<Category> Categories()=> dbContext.Categories.AsNoTracking().ToList();

        public Category GetById(int id) => dbContext.Categories.AsNoTracking().SingleOrDefault(categoryId => categoryId.Id == id);
         
       
    }
}
