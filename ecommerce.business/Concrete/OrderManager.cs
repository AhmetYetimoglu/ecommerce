using System.Collections.Generic;
using ecommerce.business.Abstract;
using ecommerce.data.Abstract;
using ecommerce.entity;

namespace ecommerce.business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void Create(Order entity)
        {
            _orderRepository.Create(entity);
        }

        public List<Order> GetOrders(string userId)
        {
            return _orderRepository.GetOrders(userId);
        }
    }
}