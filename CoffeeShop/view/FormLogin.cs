using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.controller;

namespace CoffeeShop
{
    public partial class FormLogin : Form
    {
        private ControllerFormLogin controller;
        private MainController mainController;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            controller = new ControllerFormLogin(this);
            mainController = MainController.GetInstance();
            mainController.formLogin = this;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string pass = textBoxPassword.Text;


            if (login == String.Empty)
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (pass == String.Empty)
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            string answer = controller.SignIn(login, pass);
            if (answer != "Успешно!")
            {
                MessageBox.Show(answer);
            }
            

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainController.OpenFormSignUp(this.Location, this);
        }

        private void FormLogin_Move(object sender, EventArgs e)
        {
        }
    }
}
