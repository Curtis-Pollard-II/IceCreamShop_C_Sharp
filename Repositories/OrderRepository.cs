using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using IceCreamShop_C_Sharp.Models;


namespace IceCreamShop_C_Sharp.Repositories
{
    public class OrderRepository
    {
        private readonly IDbConnection _db;

        public OrderRepository(IDbConnection db)
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