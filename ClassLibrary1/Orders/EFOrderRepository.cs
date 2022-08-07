using MiMWebsite.Contracts.Orders;
using MiMWebsite.Domains.Orders;
using MiMWebsite.Service.Common;

namespace MiMWebsite.Service.Orders
{
    public class EFOrderRepository : OrderRepository
    {
        private readonly BenDbcontext dbContext;

        public EFOrderRepository(BenDbcontext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Order Add(Order order)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetByPerson(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> Orders()
        {
            throw new NotImplementedException();
        }

        public Order Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
