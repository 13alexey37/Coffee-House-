using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CoffeeShop.model.tables
{
    public class TableIngredients
    {
        public List<Ingredient> GetAllingredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = "CALL ingredients_select_all";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    ingredients.Add(new Ingredient()
                    {
                        id = reader.GetInt32("id"),
                        name = reader.GetString("name"),
                        price = reader.GetDecimal("price"),
                        amount = reader.GetBoolean("amount"),
                        shelfTime = reader.GetDateTime("shelflife")
                    });
                }
            }
            catch (Exception)
            {
            }

            return ingredients;
        }

        public void DeleteIngredient(int id)
        {
            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = $"CALL ingredients_delete({id})";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                reader.Close();
            }
            catch (Exception)
            {
            }
        }

        public void AddNewIngredient(Ingredient ingr)
        {
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            mySqlCommand.CommandText = $"CALL ingredients_insert('{ingr.id}','{ingr.name}','{ingr.price}','{ingr.amount}','{ingr.shelfTime}')";
            mySqlCommand.ExecuteNonQuery();
        }

        public void UpdateIngredient(Ingredient ingr)
        {
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            mySqlCommand.CommandText = $"CALL ingredient_update('{ingr.id}','{ingr.name}','{ingr.price}','{ingr.amount}','{ingr.shelfTime}')";
            mySqlCommand.ExecuteNonQuery();
        }
    }
}
