using AutoMapper;
using MiMWebsite.Contracts.Categories;
using MiMWebsite.Domains.Categories;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Categories
{
    public class EFCategoryCommand : CategoryCommandRepository
    {
        private readonly BentiStoreDbContext dbContext;
        private readonly IMapper mapper;
        public EFCategoryCommand(BentiStoreDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public Category Add(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
            return category;
        }

        public void DeleteCategory(int id)
        {
            var result = dbContext.Categories.SingleOrDefault(categoryId => categoryId.Id == id);
            dbContext.Categories.Remove(result);
            dbContext.SaveChanges();
        }

        public Category Update(Category category)
        {
            var currentCategory = dbContext.Categories.SingleOrDefault(categoryId => categoryId.Id == category.Id);
            if(!(currentCategory  is null))
            {
                mapper.Map(category, currentCategory);
                dbContext.SaveChanges();
                return currentCategory;
               
            }
            return null;
        }
    }
}
