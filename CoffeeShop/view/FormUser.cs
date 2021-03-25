using System;
using System.Windows.Forms;
using CoffeeShop.controller;

namespace CoffeeShop
{
    public partial class FormUser : Form
    {
        private ControllerFormUser controller;
        private MainController mainController;
        string str = "";

        public FormUser()
        {
            InitializeComponent();
            controller = new ControllerFormUser(this);
            mainController = MainController.GetInstance();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            controller.FillProductsList();
            controller.FillProfile();
            dateTimePickerHistoryTo.Value = DateTime.Now;
            dateTimePickerHistoryFrom.Value = dateTimePickerHistoryTo.Value.Date.AddMonths(-1);
            controller.FillHistory();
        }

        public void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainController.CloseFormLogin();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            panelShopingCart.Controls.Clear();
            mainController.User.userShopCart.Clear();
        }


        private void tabControlUser_Selecting(object sender, TabControlCancelEventArgs e)
        {
            controller.FillShoppingCart();
            controller.FillProductsList();
        }


        private void buttonBuy_Click(object sender, EventArgs e)
        {
            //код на дз
            controller.FillHistory();
        }

        private void buttonRefuse_Click(object sender, EventArgs e)
        {
            controller.FillProfile();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            string pass = textBoxPassword.Text;
            string pass2 = textBoxPassword2.Text;
            string username = textBoxUsername.Text;
            string phone = maskedTextBoxPhone.Text;
            string city = textBoxCity.Text;
            string bday = dateTimePicker.Value.ToShortDateString();

            if (pass != pass2)
            {
                MessageBox.Show("Пароли не совпадают!");
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
                phone = phone.Remove(0, 1);
                phone = System.Text.RegularExpressions.Regex.Replace(phone, $@"-", string.Empty);

                temp_phone = phone;
            }

            MessageBox.Show(controller.EditUser(pass,username,temp_phone,city,birthday));
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainController.LeaveAccount(this);
        }

        private void panelShoppingCartButttons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHystoryRefresh_Click(object sender, EventArgs e)
        {
            controller.FillHistory();
        }
    }
}
