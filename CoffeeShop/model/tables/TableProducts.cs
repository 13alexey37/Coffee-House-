using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MySql.Data.MySqlClient;

namespace CoffeeShop.model.tables
{
    public class TableProducts
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = "CALL products_select_all";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Product prod;

                    prod = new Product();
                    prod.id = reader.GetInt32("id");
                    prod.name = reader.GetString("name");
                    prod.price = reader.GetDecimal("price");
                    prod.info = reader.IsDBNull(reader.GetOrdinal("info")) ? "" : reader.GetString("info");
                    prod.amount = reader.GetBoolean("amount");


                    byte[] imageBytes = reader.IsDBNull(reader.GetOrdinal("picture")) ? null : (byte[])reader["picture"];

                    if (imageBytes != null)
                    {
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            prod.image = System.Drawing.Image.FromStream(ms);
                        }
                    }

                    products.Add(prod);
                }
                reader.Close();
            }
            catch (Exception)
            {
            }
            return products;

        }

        public List<Product> GetAllAvalibleProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = "CALL products_select_all_avalible";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                
                Product prod;

                while (reader.Read())
                {
                    prod = new Product();
                    prod.id = reader.GetInt32("id");
                    prod.name = reader.GetString("name");
                    prod.price = reader.GetDecimal("price");
                    prod.info = reader.IsDBNull(reader.GetOrdinal("info")) ? "" : reader.GetString("info");
                    prod.amount = reader.GetBoolean("amount");


                    byte[] imageBytes = reader.IsDBNull(reader.GetOrdinal("picture")) ? null : (byte[])reader["picture"];

                    if (imageBytes != null)
                    {
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            prod.image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    

                    products.Add(prod);
                    
                }
                reader.Close();
            }
            catch (Exception)
            {
            }

            return products;
        }

        public void DeleteProduct(int id)
        {
            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = $"CALL products_delete({id})";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                reader.Close();
            }
            catch (Exception)
            {
            }
        }

        public void AddNewProduct(Product prod)
        {
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            mySqlCommand.CommandText = $"CALL products_insert('{prod.id}','{prod.name}','{prod.price}','{prod.info}','{prod.amount}','{prod.ImageToByte()}')";
            mySqlCommand.ExecuteNonQuery();
        }

        public void UpdateProducts(Product prod)
        {
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            
            mySqlCommand.CommandText = $"CALL products_update('{prod.id}','{prod.name}','{prod.price}','{prod.info}','{prod.amount}','{prod.ImageToByte()}')";
            mySqlCommand.ExecuteNonQuery();
        }

        public void UpdateImage(Product prod)
        {
            var userImage = prod.ImageToByte();
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            
            //var command = new MySqlCommand("", conn);

            mySqlCommand.CommandText = "UPDATE products SET name = @in_name, price = @in_price, info = @in_info, amount = @in_amount, picture = @in_picture WHERE p.id = @in_id;";

            var param_in_picture = new MySqlParameter("@in_picture", MySqlDbType.Blob, userImage.Length);
            var param_in_price = new MySqlParameter("@in_price", MySqlDbType.Decimal, 8);
            var param_in_info = new MySqlParameter("@in_info", MySqlDbType.String, prod.info.Length);
            var param_in_name = new MySqlParameter("@in_name", MySqlDbType.VarChar, 50);
            var param_in_amount = new MySqlParameter("@in_amount", MySqlDbType.Int32, 1);
            var param_in_id = new MySqlParameter("@in_id", MySqlDbType.Int32, 10);

            param_in_picture.Value = prod.image;
            param_in_price.Value = prod.price;
            param_in_info.Value = prod.info;
            param_in_name.Value = prod.name;
            param_in_amount.Value = prod.amount;
            param_in_id.Value = prod.id;

            mySqlCommand.Parameters.Add(param_in_picture);
            mySqlCommand.Parameters.Add(param_in_price);
            mySqlCommand.Parameters.Add(param_in_info);
            mySqlCommand.Parameters.Add(param_in_name);
            mySqlCommand.Parameters.Add(param_in_amount);
            mySqlCommand.Parameters.Add(param_in_id);

            mySqlCommand.ExecuteNonQuery();
        }
    }
}
