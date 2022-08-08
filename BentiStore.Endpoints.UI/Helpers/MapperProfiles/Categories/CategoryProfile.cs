using AutoMapper;
using MiMWebsite.Domains.Categories;

namespace BentiStore.Endpoints.UI.Helpers.MapperProfiles.Categories
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, Category>();

        }
    }
}
