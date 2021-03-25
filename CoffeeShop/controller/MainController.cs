using System;
using System.Drawing;
using System.Security.AccessControl;
using System.Windows.Forms;
using CoffeeShop.view;

namespace CoffeeShop.controller
{
    public class MainController
    {
        private static MainController _instance = null;

        private FormSignUp formSignUp;
        private DbManager dbManager;
        public FormLogin formLogin;
        public User User { get; set; }

        private MainController()
        {
            dbManager = DbManager.GetInstance();
        }

        public void OpenFormSignUp(Point locPoint, FormLogin formLog)
        {
            formSignUp = new FormSignUp();
            formLogin = formLog;
            formLogin.Hide();
            formSignUp.Show();
            formSignUp.Location = locPoint;
        }

        public void CloseFormSignUp()
        {
            formSignUp.Close();
            formLogin.Show();
        }

        public void CloseFormLogin()
        {
            formLogin.Close();
        }

        public void ShowFormLogin()
        {
            formLogin.Show();
        }

        public static MainController GetInstance()
        {
            return _instance ?? (_instance = new MainController());
        }

        public void LeaveAccount(FormUser form)
        {
            form.FormClosing -= form.FormUser_FormClosing;
            form.FormClosing += ShowFormLogin;
            form.Close();
        }

        private void ShowFormLogin(object sender, FormClosingEventArgs e)
        {
            ShowFormLogin();
        }

        public void OpenForm()
        {
            switch (User.levelAccess)
            {
                case LevelAccess.banned:
                    break;
                case LevelAccess.user:
                    FormUser formUser = new FormUser();
                    formLogin.Hide();
                    formUser.Show();
                    break;
                case LevelAccess.seller:

                    break;
                case LevelAccess.zavhoz:

                    break;
                case LevelAccess.admin:
                    FormAdmin formAdmin = new FormAdmin();
                    formLogin.Hide();
                    formAdmin.Show();
                    break;
            }
        }
    }
}