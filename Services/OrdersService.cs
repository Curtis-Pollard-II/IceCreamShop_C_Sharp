using System.Collections.Generic;
using IceCreamShop_C_Sharp.Models;
using IceCreamShop_C_Sharp.Repositories;

namespace IceCreamShop_C_Sharp.Services
{
    public class OrdersService
    {
        private readonly OrdersRepository _ordersRepo;
        public OrdersService(OrdersRepository ordersRepo)
        {
            _ordersRepo = ordersRepo;
        }

        internal List<Order> GetOrders()
        {
            List<Order> orders = _ordersRepo.GetOrders();
            return orders;
        }
    }
}