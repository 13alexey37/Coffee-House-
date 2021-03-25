using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CoffeeShop.model.tables
{
    public class TableUsers
    {
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = "CALL users_select_all()";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User()
                    {
                        login = reader.GetString("login"),
                        username = reader.GetString("username"),
                        phonenumber = reader.GetString("phonenumber"),
                        birthday = reader.GetDateTime("birthday"),
                        city = reader.GetString("city"),
                        levelAccess = (LevelAccess)reader.GetInt32("level"),
                        userShopCart = new List<(int, int)>()
                    });
                }
                reader.Close();
            }
            catch (Exception)
            {
            }

            return users;
        }

        public User GetOneUser(string in_login, string in_pass)
        {
            User user = new User();
            try
            {
                MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
                mySqlCommand.CommandText = "CALL users_select_one('" + in_login + "','" + in_pass + "')";

                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    user.login = reader.GetString("login");
                    user.username = reader.GetString("username");
                    user.phonenumber = reader.IsDBNull(reader.GetOrdinal("phone number")) ? "-1" : reader.GetString("phone number");
                    user.birthday = reader.IsDBNull(reader.GetOrdinal("birthday")) ? DateTime.MinValue.Date : reader.GetDateTime("birthday");
                    user.city = reader.IsDBNull(reader.GetOrdinal("city")) ? null : reader.GetString("city");
                    user.userShopCart = new List<(int, int)>();
                    user.levelAccess = (LevelAccess)reader.GetInt32("level");
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка " + e);
            }
            return user;
        }

        public void AddNewUser(User user)
        {
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            var bday = $"{user.birthday:yyyy-MM-dd}";
            string phone = user.phonenumber;
            mySqlCommand.CommandText = $@"CALL users_insert('{user.login}','{user.pass}','{user.username}','{phone}','{bday}','{user.city}')";
            mySqlCommand.ExecuteNonQuery();
        }

        public void UpdateUser(User user)
        {
            MySqlCommand mySqlCommand = DbConnector.GetInstance().GetMySqlCommand();
            mySqlCommand.CommandText = $@"CALL users_update('{user.login}','{user.pass}','{user.username}','{user.phonenumber}','{user.birthday:yyyy-MM-dd}','{user.city}','{(int)user.levelAccess}')";
            mySqlCommand.ExecuteNonQuery();
        }
    }
}
