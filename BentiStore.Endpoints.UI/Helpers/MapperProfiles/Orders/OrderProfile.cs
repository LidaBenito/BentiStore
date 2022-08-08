using AutoMapper;
using MiMWebsite.Domains.Orders;

namespace BentiStore.Endpoints.UI.Helpers.MapperProfiles.Orders
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, Order>();

        }
    }
}
