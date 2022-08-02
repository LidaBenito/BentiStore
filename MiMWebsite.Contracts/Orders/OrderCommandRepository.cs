using MiMWebsite.Domains.Orders;

namespace MiMWebsite.Contracts.Orders
{
    public interface OrderCommandRepository
    {
        void Delete(int id);
        Order Add(Order order);
        Order Update(Order order);
    }
}
