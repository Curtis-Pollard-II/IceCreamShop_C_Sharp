using System.ComponentModel.DataAnnotations;


namespace IceCreamShop_C_Sharp.Models
{
    public class Order
    {
        public Order (string name, double price, int scoops, string toppings, int id)
        {
            Name = name;
            Price = price;
            Scoops = scoops;
            Toppings = toppings;
            Id = id;
        }
        public Order ()
        {

        }

        [Required]
        [MaxLength(100)]

        public string Name { get; set; }
        public double Price { get; set; }
        public int? Scoops { get; set; }
        public string Toppings { get; set; }
        public int Id { get; set; }

    }
}