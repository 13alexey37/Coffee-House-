using CoffeeShop.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.view
{
    public partial class FormSignUp : Form
    {
        private MainController mainController;
        private ControllerFormSingUp controller;

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            mainController = MainController.GetInstance();
            controller = new ControllerFormSingUp(this);
            dateTimePicker.Value = dateTimePicker.MinDate;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainController.CloseFormSignUp();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string pass = textBoxPassword.Text;
            string pass2 = textBoxPassword2.Text;
            string login = textBoxLogin.Text;
            string username = textBoxUsername.Text;
            string phone = maskedTextBoxPhone.Text;
            string city = textBoxCity.Text;
            string bday = dateTimePicker.Value.ToShortDateString();

            if (pass != pass2)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }
            
            if (login == String.Empty)
            {
                MessageBox.Show("Введите логин!");
                return;
            }

            if (pass == String.Empty)
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (pass2 == String.Empty)
            {
                MessageBox.Show("Введите подтверждение пароля!");
                return;
            }

            if (username == String.Empty)
            {
                MessageBox.Show("Введите имя пользователя!");
                return;
            }

            MessageBox.Show(controller.Registration(login, pass, username, phone, bday, city));
        }

        private void maskedTextBoxPhone_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker) delegate() { maskedTextBoxPhone.Select(3, 0); });
        }

        private void FormSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainController.ShowFormLogin();
        }
    }
}
