using System.Collections.Generic;
using ecommerce.entity;

namespace ecommerce.data.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}