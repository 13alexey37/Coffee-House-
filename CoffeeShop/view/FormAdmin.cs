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
    public partial class FormAdmin : Form
    {
        private ControllerFormAdmin controller;

        public FormAdmin()
        {
            InitializeComponent();
            controller = new ControllerFormAdmin(this);
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {
            controller.FillAdminProductsList();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
