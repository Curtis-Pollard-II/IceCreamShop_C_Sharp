using System;
using System.Collections.Generic;
using IceCreamShop_C_Sharp.Models;

namespace IceCreamShop_C_Sharp.db
{
    public static class Db
    {
        public static List<Order> Orders { get; set; } = new List<Order>(){
            new Order("Peanut Butter Perfection", 8.34, 2, "reese's", 1),
            new Order("BlackBerry Season", 7.34, 1, "Fresh Blackberries", 1),
            new Order("Cookie Dough Do", 8.59, 2, "Milk Chocolate Chips", 1),
        };
    }
}