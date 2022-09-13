using System.Collections.Generic;
using IceCreamShop_C_Sharp.Models;
using IceCreamShop_C_Sharp.Repositories;

namespace IceCreamShop_C_Sharp.Services
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepo;
        public OrderService(OrderRepository orderRepo);
        {
            _orderRepo = OrderRepo;
        }

        internal List<Order> GetOrders();
        {
            List<Order> orders = _orderRepo.GetOrders();
            return orders;
        }
    }
}