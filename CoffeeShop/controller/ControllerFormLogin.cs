using System.Windows.Forms;
using CoffeeShop.controller;
using CoffeeShop.model.tables;

namespace CoffeeShop
{
    public class ControllerFormLogin
    {
        private FormLogin form;
        private DbManager dbManager;
        private MainController mainController;

        public ControllerFormLogin(FormLogin form)
        {
            this.form = form;
            dbManager = DbManager.GetInstance();
            mainController = MainController.GetInstance();
        }

        public string SignIn(string login, string pass)
        {
            User checkUser = dbManager.tableUsers.GetOneUser(login, pass);
            if (checkUser.username != null)
            {
                if (checkUser.levelAccess == LevelAccess.banned)
                {
                    return "Вы были заблокированы";
                }

                mainController.User = checkUser;
                mainController.OpenForm();
                return "Успешно!";
            }
            else
            {
                return "Неверная пара логин/пароль!";
            }

            
        }
    }
}