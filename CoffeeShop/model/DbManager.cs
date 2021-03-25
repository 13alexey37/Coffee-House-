using CoffeeShop.model.tables;

namespace CoffeeShop
{
    public class DbManager
    {
        private static DbManager _instance = null;

        public TableIngredients tableIngredients { get; private set; }
        public TableProducts tableProducts{ get; private set; }
        public TablePurchases tablePurchases { get; private set; }
        public TableUsers tableUsers{ get; private set; }


        public DbManager()
        {
            this.tableIngredients = new TableIngredients();
            this.tableProducts = new TableProducts();
            this.tablePurchases = new TablePurchases();
            this.tableUsers = new TableUsers();
        }

        public static DbManager GetInstance()
        {
            return _instance ?? (_instance = new DbManager());
        }
    }
}