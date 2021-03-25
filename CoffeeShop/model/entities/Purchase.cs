using System;
using System.Collections.Generic;

namespace CoffeeShop
{
    public class Purchase
    {
        public int id { get; set; }
        public DateTime datetime { get; set; }
        public string loginClient { get; set; }
        public decimal totalPrice { get; set; }
        public List<(int prod_id, int amount)> prod_ids { get; set; }
    }
}