using System;
using System.Collections.Generic;

namespace CoffeeShop
{
    public enum LevelAccess
    {
        banned,
        user,
        seller,
        zavhoz,
        admin
    }

    public class User
    {
        public string login { get; set; }
        public string pass { get; set; }
        public string username { get; set; }
        public string phonenumber { get; set; }
        public DateTime birthday { get; set; }
        public string city { get; set; }
        public LevelAccess levelAccess { get; set; }
        public List<(int prod_id, int amount)> userShopCart { get; set; }
    }
}