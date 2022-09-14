using System.ComponentModel.DataAnnotations;


namespace IceCreamShop_C_Sharp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int? Scoops { get; set; }
        public string Toppings { get; set; }
        public int Cone { get; set; }

    }
}