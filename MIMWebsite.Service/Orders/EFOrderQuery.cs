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
    }
}
