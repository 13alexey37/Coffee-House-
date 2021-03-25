using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.model.tables;
using CoffeeShop.view;

namespace CoffeeShop.controller
{
    class ControllerFormSingUp
    {
        private FormSignUp form;
        private DbManager dbManager;

        public ControllerFormSingUp(FormSignUp form)
        {
            this.form = form;
            dbManager = DbManager.GetInstance();
        }

        public string Registration(string login, string pass, string username, string phone, string bday, string city)
        {
            if (dbManager.tableUsers.GetOneUser(login, pass).username != null)
            {
                return "Такой пользователь уже существует!";
            }

            DateTime birthday;
            if (bday != "")
            {
                birthday = DateTime.Parse(bday);
            }
            else
            {
                birthday = DateTime.MinValue;
            }

            string temp_phone = "-1";

            if (phone == String.Empty)
            {
                temp_phone = "-1";
            }
            else
            {
                phone = phone.Remove(0,1);
                phone = System.Text.RegularExpressions.Regex.Replace(phone,$@"-",string.Empty);

                temp_phone = phone;
            }

            User user = new User() { login = login, pass = pass, birthday = birthday, username = username, phonenumber = temp_phone, city = city };
            dbManager.tableUsers.AddNewUser(user);
            return "Пользователь создан успешно!";

        }
    }
}
