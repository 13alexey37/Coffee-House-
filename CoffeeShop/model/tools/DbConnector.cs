using MySql.Data.MySqlClient;

namespace CoffeeShop
{
    public class DbConnector
    {
        private static DbConnector _instance = null;
        private MySqlCommand _mySqlCommand;
        private MySqlConnection _mySqlConnection;

        public DbConnector()
        {
            string connectionString = "Server=127.0.0.1;UserId=root;Password=1234;Database=coffee_shop";

            _mySqlConnection = new MySqlConnection(connectionString);
            _mySqlConnection.Open();

            _mySqlCommand = new MySqlCommand();
            _mySqlCommand.Connection = _mySqlConnection;
        }

        ~DbConnector()
        {
            _mySqlConnection.Close();
        }


        public static DbConnector GetInstance()
        {
            return _instance ?? (_instance = new DbConnector());
        }

        public MySqlCommand GetMySqlCommand()
        {
            return _mySqlCommand;
        }
    }
}