using AutoMapper;
using MiMWebsite.Contracts.Orders;
using MiMWebsite.Domains.Orders;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Orders
{
    public class EFOrderCommand : OrderCommandRepository
    {
        private readonly BentiStoreDbContext dbContext;
        private readonly IMapper mapper;


        public EFOrderCommand(BentiStoreDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public Order Add(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
            return order;
        }

        public void Delete(int id)
        {
            var order = dbContext.Orders.FirstOrDefault(o => o.Id == id);
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
        }

        public Order Update(Order order)
        {
            var currentOrder = dbContext.Orders.SingleOrDefault(orderId => orderId.Id == order.Id);
            if (currentOrder != null)
            {
                mapper.Map(order, currentOrder);
                dbContext.SaveChanges();
                return currentOrder;

            }
            return null;
        }
    }
}
