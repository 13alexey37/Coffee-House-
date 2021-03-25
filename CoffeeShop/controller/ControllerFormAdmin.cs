using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CoffeeShop.view;

namespace CoffeeShop.controller
{
    public class ControllerFormAdmin
    {
        private FormAdmin form;
        private DbManager dbManager;
        private List<Product> products;
        private FormExample formExample;

        public ControllerFormAdmin(FormAdmin form)
        {
            this.form = form;
            dbManager = DbManager.GetInstance();
        }

        public void FillAdminProductsList()
        {
            products = dbManager.tableProducts.GetAllProducts();
            formExample = new FormExample();
            PictureBox pbox = new PictureBox();
            Button btn = new Button();
            GroupBox groupBoxExample = formExample.groupBoxProduct;
            form.panelAdmin.Controls.Clear();
            foreach (var product in products)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Size = groupBoxExample.Size;
                groupBox.Controls.Add(pbox = new PictureBox()
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
                groupBox.Controls.Add(btn = new Button()
                {
                    Name = product.id.ToString(),
                    Size = formExample.button1.Size,
                    Location = formExample.button1.Location,
                    Text = "Редактировать продукт"
                });

                groupBox.Controls.Add(new NumericUpDown()
                {
                    Size = formExample.numericUpDown1.Size,
                    Location = formExample.numericUpDown1.Location,
                    Maximum = 20,
                    Minimum = 0,
                    Value = 1
                });

                groupBox.Text = product.name;
                groupBox.Location = Point.Empty + new Size(0, groupBox.Height * (form.panelAdmin.Controls.Count));
                form.panelAdmin.Controls.Add(groupBox);
                pbox.Click += Picture_Click;
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, System.EventArgs e)
        {
            var btn = (Button) sender;
            Image image;
            foreach (Control c in btn.Parent.Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    image = c.BackgroundImage;
                    var prod = products.FindAll(f => f.id == int.Parse(btn.Name))[0];
                    prod.image = image;
                    dbManager.tableProducts.UpdateImage(prod);
                }
            }
        }

        private void Picture_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Все файлы |.*| JPEG |.jpg;.jpeg | PNG |.png | GIF |.gif ";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var t = (PictureBox) sender;
                t.BackgroundImage = Image.FromFile(ofd.FileName);
            }
        }
    }

}