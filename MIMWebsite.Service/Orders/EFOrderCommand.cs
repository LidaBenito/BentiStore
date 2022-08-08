using MiMWebsite.Contracts.Orders;
using MiMWebsite.Domains.Orders;
using MIMWebsite.Service.Common;
using System;

namespace MiMWebsite.Service.Orders
{
    public class EFOrderCommand : OrderCommandRepository
    {
        private readonly BentiStoreDbContext dbContext;

        public EFOrderCommand(BentiStoreDbContext dbContext)
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

        public Order Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
