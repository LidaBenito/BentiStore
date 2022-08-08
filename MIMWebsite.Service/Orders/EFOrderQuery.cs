using Microsoft.EntityFrameworkCore;
using MiMWebsite.Contracts.Orders;
using MiMWebsite.Domains.Orders;
using MIMWebsite.Service.Common;

namespace MiMWebsite.Service.Orders
{
    public class EFOrderQuery : OrderQueryRepository
    {
        private readonly BentiStoreDbContext dbContext;

        public EFOrderQuery(BentiStoreDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Order> GetByDate(DateTime asDate,DateTime toDate)
        {
            List<Order> orders = new(10);
          if (asDate != default && toDate != default)
            {
                orders = dbContext.Orders.Where(orderDate => orderDate.Date >= asDate &&
                orderDate.Date <= toDate).ToList();
            }
          else if(asDate !=default || toDate != default)
            {
                orders = dbContext.Orders.Where(orderDate => orderDate.Date >= asDate ||
                orderDate.Date <= toDate).ToList();
            }
          return orders.OrderByDescending(paymentdate => paymentdate.Date).ToList();
        }

        public Order GetById(int id) =>dbContext.Orders.AsNoTracking().SingleOrDefault(orderId => orderId.Id == id);
            

     

        public List<Order> Orders()=> dbContext.Orders.AsNoTracking().ToList();
         

        

    }
}
