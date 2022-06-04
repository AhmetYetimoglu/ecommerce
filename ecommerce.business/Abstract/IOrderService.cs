using System.Collections.Generic;
using ecommerce.entity;

namespace ecommerce.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
        List<Order> GetOrders(string userId);
    }
}