using AutoMapper;
using MiMWebsite.Domains.Products;

namespace BentiStore.Endpoints.UI.Helpers.MapperProfiles.Products
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, Product>();

        }
    }
}
