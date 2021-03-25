using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoffeeShop.model.tables
{
    public class TablePurchases
    {
        public List<Purchase> GetAllPurchases()
        {
            List<Purchase> purchases = new List<Purchase>();

            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = "CALL purcheses_get_all_purcheses";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Purchase purch = new Purchase();
                    int prev_id = -1;
                    if (reader.GetInt32("id") != prev_id)
                    {
                        prev_id = reader.GetInt32("id");
                        purch.id = prev_id;
                        purch.datetime = reader.GetDateTime("name");
                        purch.loginClient = reader.GetString("login client");
                        purch.totalPrice = reader.GetDecimal("total price");
                        var prods = (reader.GetInt32("prod_id"), reader.GetInt32("amount"));
                        purch.prod_ids.Add(prods);
                        purchases.Add(purch);
                    }
                    else
                    {
                        var prods = (reader.GetInt32("prod_id"), reader.GetInt32("amount"));
                        purchases[purchases.Count-1].prod_ids.Add(prods);
                    }
                }
            }
            catch (Exception)
            {
            }

            return purchases;
        }

        public List<Purchase> GetUserPurchases(string login, DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            List<Purchase> purchases = new List<Purchase>();

            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = $"CALL purcheses_get_purchese_by_user({login},{dateTimeFrom},{dateTimeTo})";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Purchase purch = new Purchase();
                    int prev_id = -1;
                    if (reader.GetInt32("id") != prev_id)
                    {
                        prev_id = reader.GetInt32("id");
                        purch.id = prev_id;
                        purch.datetime = reader.GetDateTime("name");
                        purch.loginClient = reader.GetString("login client");
                        purch.totalPrice = reader.GetDecimal("total price");
                        var prods = (reader.GetInt32("prod_id"), reader.GetInt32("amont"));
                        purch.prod_ids.Add(prods);
                        purchases.Add(purch);
                    }
                    else
                    {
                        var prods = (reader.GetInt32("prod_id"), reader.GetInt32("amont"));
                        purchases[purchases.Count - 1].prod_ids.Add(prods);
                    }
                }
            }
            catch (Exception)
            {
            }

            return purchases;
        }

        public void DeletePurchases(int id)
        {
            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = $"CALL purcheses_delete({id})";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                reader.Close();
            }
            catch (Exception)
            {
            }
        }

        public void AddNewPurchases(Purchase purch, int prod_id, int prod_amount)
        {
            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                string commandString = $"INSERT INTO purcheses (datetime, `login client`, `total price`) VALUES(NOW(), {purch.loginClient}, {purch.totalPrice}); SET @purch_id = LAST_INSERT_ID();";
                int temp_int = 10; //кол-во товаров;
                for (int i = 0; i < temp_int; i++)
                {
                    commandString += $" INSERT INTO `purcheses/products` VALUES (@purch_id,{prod_id},{prod_amount})";
                }

                mySqlCommand.CommandText = commandString;
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
    }
}
