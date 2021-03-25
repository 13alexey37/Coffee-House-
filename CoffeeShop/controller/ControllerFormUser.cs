

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CoffeeShop.controller;
using CoffeeShop.view;

namespace CoffeeShop
{
    public class ControllerFormUser
    {
        private FormUser form;
        private DbManager dbManager;
        private List<Product> products;
        private List<Purchase> purchases;
        private FormExample formExample;

        public ControllerFormUser(FormUser form)
        {
            this.form = form;
            dbManager = DbManager.GetInstance();
        }

        public void FillShoppingCart()
        {
            formExample = new FormExample();
            GroupBox groupBoxExample = formExample.groupBoxProduct;
            form.panelShopingCart.Controls.Clear();
            NumericUpDown nud;
            Button but;
            
            foreach (var productInShopCart in MainController.GetInstance().User.userShopCart)
            {
                var amount = productInShopCart.amount;
                var prod_id = productInShopCart.prod_id;
                var product = products.Find(f => f.id == prod_id);

                GroupBox groupBox = new GroupBox();
                groupBox.Size = groupBoxExample.Size;
                groupBox.Name = prod_id.ToString();
                groupBox.Controls.AddRange(new Control[]{
                new PictureBox()
                {
                    Size = formExample.pictureBoxProductImage.Size,
                    Location = formExample.pictureBoxProductImage.Location,
                    BackgroundImage = product.image ?? formExample.pictureBoxProductImage.BackgroundImage,
                    BackgroundImageLayout = formExample.pictureBoxProductImage.BackgroundImageLayout
                },
                new Label()
                {
                    Size = formExample.labelProductPrice.Size,
                    Location = formExample.labelProductPrice.Location,
                    Text=(product.price==decimal.Zero)? formExample.labelProductPrice.Text : product.price.ToString(),
                    AutoSize=true
                },
                new Label()
                {
                    Size = formExample.labelProductAmount.Size,
                    Location = formExample.labelProductAmount.Location,
                    Text=product.amount?"Есть в наличии": formExample.labelProductAmount.Text,
                    AutoSize=true
                },
                new Label()
                {
                    Size = formExample.labelProductInfo.Size,
                    Location = formExample.labelProductInfo.Location,
                    Text=(product.info=="")? formExample.labelProductInfo.Text : product.info,
                    AutoSize=true
                },
                but = new Button()
                {
                    Name = product.id.ToString(),
                    Size = formExample.button1.Size,
                    Location = formExample.button1.Location,
                    Text = "Убрать из корзины"
                },

                nud = new NumericUpDown()
                {
                    Size = formExample.numericUpDown1.Size,
                    Location = formExample.numericUpDown1.Location,
                    Maximum = 20,
                    Minimum = 0,
                    Value = amount
                }
                })
                ;
                but.Click += buttonDontBuyClick;
                nud.ValueChanged += NudOnValueChanged;
                groupBox.Text = product.name;
                groupBox.Location = Point.Empty + new Size(0, groupBox.Height * (form.panelShopingCart.Controls.Count));
                form.panelShopingCart.Controls.Add(groupBox);
            }
        }

        public void FillProductsList()
        {
            products = dbManager.tableProducts.GetAllAvalibleProducts();
            formExample = new FormExample();
            GroupBox groupBoxExample = formExample.groupBoxProduct;
            form.panelUser.Controls.Clear();
            foreach (var product in products)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Size = groupBoxExample.Size;
                groupBox.Controls.Add(new PictureBox()
                {
                    Size = formExample.pictureBoxProductImage.Size,
                    Location = formExample.pictureBoxProductImage.Location,
                    BackgroundImage = product.image ?? formExample.pictureBoxProductImage.BackgroundImage,
                    BackgroundImageLayout = formExample.pictureBoxProductImage.BackgroundImageLayout
                });
                groupBox.Controls.Add(new Label()
                {
                    Size = formExample.labelProductPrice.Size,
                    Location = formExample.labelProductPrice.Location,
                    Text = (product.price == decimal.Zero)
                        ? formExample.labelProductPrice.Text
                        : product.price.ToString(),
                    AutoSize = true
                });
                groupBox.Controls.Add(new Label()
                {
                    Size = formExample.labelProductAmount.Size,
                    Location = formExample.labelProductAmount.Location,
                    Text = product.amount ? "Есть в наличии" : formExample.labelProductAmount.Text,
                    AutoSize = true
                });
                groupBox.Controls.Add(new Label()
                {
                    Size = formExample.labelProductInfo.Size,
                    Location = formExample.labelProductInfo.Location,
                    Text = (product.info == "") ? formExample.labelProductInfo.Text : product.info,
                    AutoSize = true
                });
                groupBox.Controls.Add(new Button()
                {
                    Name = product.id.ToString(),
                    Size = formExample.button1.Size,
                    Location = formExample.button1.Location,
                    Text = formExample.button1.Text
                });

                groupBox.Controls.Add(new NumericUpDown()
                {
                    Size = formExample.numericUpDown1.Size,
                    Location = formExample.numericUpDown1.Location,
                    Maximum = 20,
                    Minimum = 0,
                    Value = 1
                });

                groupBox.Controls.Add(new Label()
                {
                    Name = "labelAmount",
                    Size = formExample.labelShoppingCartAmount.Size,
                    Location = formExample.labelShoppingCartAmount.Location,
                    Text = "Уже в корзине: " + MainController.GetInstance().User.userShopCart
                        .Find(f => f.prod_id == product.id).amount,
                    AutoSize = true
                });

                groupBox.Text = product.name;
                groupBox.Location = Point.Empty + new Size(0, groupBox.Height * (form.panelUser.Controls.Count));
                form.panelUser.Controls.Add(groupBox);
            }

            foreach (Control control in form.panelUser.Controls)
            {
                foreach (Control control1 in control.Controls)
                {
                    if (control1.GetType() == typeof(Button))
                    {
                        control1.Click += buttonBuyClick;
                    }
                }
            }
        }

        public void buttonBuyClick(object sender, EventArgs e)
        {
            var but = sender as Button;
            var grBox = but.Parent;
            var amount = 0;
            foreach (Control control in grBox.Controls)
            {
                if (control.GetType() == typeof(NumericUpDown))
                {
                    amount = (int)(control as NumericUpDown).Value;
                }
            }

            var shopcart = MainController.GetInstance().User.userShopCart;
            if (shopcart.Find(f => f.prod_id == int.Parse(but.Name)).prod_id == 0)
            {
                shopcart.Add((int.Parse(but.Name), amount));
            }
            else
            {
                var index = shopcart.FindIndex(f => f.prod_id == int.Parse(but.Name));
                amount += shopcart[index].amount;
                shopcart[index] = (int.Parse(but.Name), amount);
            }

            grBox.Controls.Find("labelAmount", false)[0].Text = "Уже в корзине: " + amount;

        }

        private void NudOnValueChanged(object sender, EventArgs e)
        {
            var nud = sender as NumericUpDown;
            var grBox = nud.Parent;
            var shopcart = MainController.GetInstance().User.userShopCart;
            if ((int)nud.Value == 0)
            {
                shopcart.RemoveAll(f => f.prod_id == int.Parse(grBox.Name));
                FillShoppingCart();
                return;
            }
            var shopcartIndex = shopcart.FindIndex(f => f.prod_id == int.Parse(grBox.Name));
            shopcart[shopcartIndex] = (shopcart[shopcartIndex].prod_id, (int)nud.Value);

        }

        public void buttonDontBuyClick(object sender, EventArgs e)
        {
            var but = sender as Button;
            MainController.GetInstance().User.userShopCart.RemoveAll(f => f.prod_id == int.Parse(but.Name));
            FillShoppingCart();
        }

        public void FillProfile()
        {
            var user = MainController.GetInstance().User;
            form.textBoxLogin.Text = user.login;
            form.textBoxCity.Text = user.city;
            form.textBoxUsername.Text = user.username;
            form.maskedTextBoxPhone.Text = user.phonenumber.Substring(1);
            form.dateTimePicker.Value = user.birthday;
        }

        public string EditUser(string pass, string username, string phone, string city, DateTime bday)
        {
            var editedUser = MainController.GetInstance().User;
            editedUser.birthday = bday;
            editedUser.city = city;
            editedUser.phonenumber = phone;
            editedUser.username = username;
            editedUser.pass = pass;

            dbManager.tableUsers.UpdateUser(editedUser);
            FillProfile();
            return "Сохранено успешно!";
        }

        public void FillHistory()
        {
            purchases = dbManager.tablePurchases.GetUserPurchases(MainController.GetInstance().User.login,
                form.dateTimePickerHistoryFrom.Value, form.dateTimePickerHistoryTo.Value);
            
            foreach (var purchase in purchases)
            {
                form.treeViewHistory.Nodes.Add($"От {purchase.datetime.ToShortTimeString()} на сумму {purchase.totalPrice}руб.");
                form.treeViewHistory.Nodes[form.treeViewHistory.Nodes.Count - 1].Nodes.AddRange((
                    from prodInfo in purchase.prod_ids
                    let product = products.Find(p => p.id == prodInfo.prod_id)
                    select new TreeNode($"{product.name} Цена: {product.price} Количество: {prodInfo.amount} Стоимость: {product.price * prodInfo.amount}")
                ).ToArray());
            }

        }
    }
}