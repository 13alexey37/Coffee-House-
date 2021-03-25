using System;

namespace CoffeeShop
{
    public class Ingredient
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public bool amount { get; set; }
        public DateTime shelfTime { get; set; }
    }
}