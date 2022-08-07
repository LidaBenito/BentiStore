using MiMWebsite.Domains.Orders;
using System;
using System.Collections.Generic;

namespace MiMWebsite.Contracts.Orders
{
    public interface OrderRepository
    {
        //List<Order> Orders();
        //Order GetById(int id);
        //Order GetByPerson(int id);
        //List<Order> GetByDate(DateTime date);
        //void Delete(int id);
        Order Add(Order order);
        //Order Update(Order order);
    }
}
