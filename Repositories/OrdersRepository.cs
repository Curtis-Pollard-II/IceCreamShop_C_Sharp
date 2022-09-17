using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using IceCreamShop_C_Sharp.Models;


namespace IceCreamShop_C_Sharp.Repositories
{
    public class OrdersRepository
    {
        private readonly IDbConnection _db;

        public OrdersRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Order> GetOrders()
        {
            string sql = @"
            SELECT * FROM Orders;
            ";
            List<Order> orders =_db.Query<Order>(sql).ToList();
            return orders;
        }
    }
}