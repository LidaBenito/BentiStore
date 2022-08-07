using MiMWebsite.Contracts.Orders;
using MiMWebsite.Domains.Orders;
using System;

namespace MiMWebsite.Infra.Orders
{
    public class OrderCommand : OrderCommandRepository
    {
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
