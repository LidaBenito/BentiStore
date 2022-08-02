using MiMWebsite.Contracts.Orders;
using MiMWebsite.Domains.Orders;
using System;
using System.Collections.Generic;

namespace MiMWebsite.Infra.Orders
{
    public class OrderQuery : OrderQueryRepository
    {
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
