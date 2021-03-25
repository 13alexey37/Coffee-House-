namespace CoffeeShop
{
    partial class FormUser
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.Purchase = new System.Windows.Forms.TabPage();
            this.panelUser = new System.Windows.Forms.Panel();
            this.tabPageShoppingCart = new System.Windows.Forms.TabPage();
            this.panelShopingCart = new System.Windows.Forms.Panel();
            this.panelShoppingCartButttons = new System.Windows.Forms.Panel();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerHistoryTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHistoryFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonHystoryRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonRefuse = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.treeViewHistory = new System.Windows.Forms.TreeView();
            this.tabControlUser.SuspendLayout();
            this.Purchase.SuspendLayout();
            this.tabPageShoppingCart.SuspendLayout();
            this.panelShoppingCartButttons.SuspendLayout();
            this.tabPageHistory.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Controls.Add(this.Purchase);
            this.tabControlUser.Controls.Add(this.tabPageShoppingCart);
            this.tabControlUser.Controls.Add(this.tabPageHistory);
            this.tabControlUser.Controls.Add(this.tabPageProfile);
            this.tabControlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUser.Location = new System.Drawing.Point(0, 0);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(656, 432);
            this.tabControlUser.TabIndex = 0;
            this.tabControlUser.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlUser_Selecting);
            // 
            // Purchase
            // 
            this.Purchase.Controls.Add(this.panelUser);
            this.Purchase.Location = new System.Drawing.Point(4, 22);
            this.Purchase.Name = "Purchase";
            this.Purchase.Padding = new System.Windows.Forms.Padding(3);
            this.Purchase.Size = new System.Drawing.Size(648, 406);
            this.Purchase.TabIndex = 0;
            this.Purchase.Text = "Покупка";
            this.Purchase.UseVisualStyleBackColor = true;
            // 
            // panelUser
            // 
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUser.Location = new System.Drawing.Point(3, 3);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(642, 400);
            this.panelUser.TabIndex = 0;
            // 
            // tabPageShoppingCart
            // 
            this.tabPageShoppingCart.Controls.Add(this.panelShopingCart);
            this.tabPageShoppingCart.Controls.Add(this.panelShoppingCartButttons);
            this.tabPageShoppingCart.Location = new System.Drawing.Point(4, 22);
            this.tabPageShoppingCart.Name = "tabPageShoppingCart";
            this.tabPageShoppingCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShoppingCart.Size = new System.Drawing.Size(648, 406);
            this.tabPageShoppingCart.TabIndex = 1;
            this.tabPageShoppingCart.Text = "Корзина";
            this.tabPageShoppingCart.UseVisualStyleBackColor = true;
            // 
            // panelShopingCart
            // 
            this.panelShopingCart.AutoScroll = true;
            this.panelShopingCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShopingCart.Location = new System.Drawing.Point(3, 3);
            this.panelShopingCart.Name = "panelShopingCart";
            this.panelShopingCart.Size = new System.Drawing.Size(642, 368);
            this.panelShopingCart.TabIndex = 0;
            // 
            // panelShoppingCartButttons
            // 
            this.panelShoppingCartButttons.Controls.Add(this.buttonBuy);
            this.panelShoppingCartButttons.Controls.Add(this.buttonClear);
            this.panelShoppingCartButttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShoppingCartButttons.Location = new System.Drawing.Point(3, 371);
            this.panelShoppingCartButttons.Name = "panelShoppingCartButttons";
            this.panelShoppingCartButttons.Size = new System.Drawing.Size(642, 32);
            this.panelShoppingCartButttons.TabIndex = 1;
            this.panelShoppingCartButttons.Paint += new System.Windows.Forms.PaintEventHandler(this.panelShoppingCartButttons_Paint);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(562, 4);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 0;
            this.buttonBuy.Text = "Оплатить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(437, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Очистить корзину";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.panel2);
            this.tabPageHistory.Controls.Add(this.panel1);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHistory.Size = new System.Drawing.Size(648, 406);
            this.tabPageHistory.TabIndex = 3;
            this.tabPageHistory.Text = "История покупок";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dateTimePickerHistoryTo);
            this.panel2.Controls.Add(this.dateTimePickerHistoryFrom);
            this.panel2.Controls.Add(this.buttonHystoryRefresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 34);
            this.panel2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Дата по";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Дата от";
            // 
            // dateTimePickerHistoryTo
            // 
            this.dateTimePickerHistoryTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHistoryTo.Location = new System.Drawing.Point(214, 8);
            this.dateTimePickerHistoryTo.Name = "dateTimePickerHistoryTo";
            this.dateTimePickerHistoryTo.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerHistoryTo.TabIndex = 1;
            // 
            // dateTimePickerHistoryFrom
            // 
            this.dateTimePickerHistoryFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHistoryFrom.Location = new System.Drawing.Point(58, 8);
            this.dateTimePickerHistoryFrom.Name = "dateTimePickerHistoryFrom";
            this.dateTimePickerHistoryFrom.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerHistoryFrom.TabIndex = 1;
            // 
            // buttonHystoryRefresh
            // 
            this.buttonHystoryRefresh.Location = new System.Drawing.Point(562, 6);
            this.buttonHystoryRefresh.Name = "buttonHystoryRefresh";
            this.buttonHystoryRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonHystoryRefresh.TabIndex = 0;
            this.buttonHystoryRefresh.Text = "Обновить";
            this.buttonHystoryRefresh.UseVisualStyleBackColor = true;
            this.buttonHystoryRefresh.Click += new System.EventHandler(this.buttonHystoryRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.treeViewHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 400);
            this.panel1.TabIndex = 1;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.dateTimePicker);
            this.tabPageProfile.Controls.Add(this.maskedTextBoxPhone);
            this.tabPageProfile.Controls.Add(this.label8);
            this.tabPageProfile.Controls.Add(this.linkLabel);
            this.tabPageProfile.Controls.Add(this.label7);
            this.tabPageProfile.Controls.Add(this.label6);
            this.tabPageProfile.Controls.Add(this.label5);
            this.tabPageProfile.Controls.Add(this.label4);
            this.tabPageProfile.Controls.Add(this.label3);
            this.tabPageProfile.Controls.Add(this.label2);
            this.tabPageProfile.Controls.Add(this.label1);
            this.tabPageProfile.Controls.Add(this.textBoxCity);
            this.tabPageProfile.Controls.Add(this.textBoxUsername);
            this.tabPageProfile.Controls.Add(this.textBoxPassword2);
            this.tabPageProfile.Controls.Add(this.textBoxPassword);
            this.tabPageProfile.Controls.Add(this.textBoxLogin);
            this.tabPageProfile.Controls.Add(this.buttonRefuse);
            this.tabPageProfile.Controls.Add(this.buttonApply);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(648, 406);
            this.tabPageProfile.TabIndex = 2;
            this.tabPageProfile.Text = "Профиль";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(344, 155);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker.TabIndex = 23;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(344, 129);
            this.maskedTextBoxPhone.Mask = "+7-000-000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPhone.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Символом * отмечены обязательные поля";
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.Location = new System.Drawing.Point(267, 290);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(135, 13);
            this.linkLabel.TabIndex = 26;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "Выйти из учетной записи";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Город";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Имя пользователя *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Повтор пароля *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(344, 181);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(100, 20);
            this.textBoxCity.TabIndex = 24;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(344, 103);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 21;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(344, 77);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword2.TabIndex = 20;
            this.textBoxPassword2.UseSystemPasswordChar = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(344, 51);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 19;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(344, 25);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.ReadOnly = true;
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 18;
            // 
            // buttonRefuse
            // 
            this.buttonRefuse.Location = new System.Drawing.Point(369, 264);
            this.buttonRefuse.Name = "buttonRefuse";
            this.buttonRefuse.Size = new System.Drawing.Size(75, 23);
            this.buttonRefuse.TabIndex = 1;
            this.buttonRefuse.Text = "Отменить";
            this.buttonRefuse.UseVisualStyleBackColor = true;
            this.buttonRefuse.Click += new System.EventHandler(this.buttonRefuse_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(223, 264);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Принять";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // treeViewHistory
            // 
            this.treeViewHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewHistory.Location = new System.Drawing.Point(0, 0);
            this.treeViewHistory.Name = "treeViewHistory";
            this.treeViewHistory.Size = new System.Drawing.Size(642, 400);
            this.treeViewHistory.TabIndex = 0;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 432);
            this.Controls.Add(this.tabControlUser);
            this.Name = "FormUser";
            this.Text = "Кофешоп";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUser_FormClosing);
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.tabControlUser.ResumeLayout(false);
            this.Purchase.ResumeLayout(false);
            this.tabPageShoppingCart.ResumeLayout(false);
            this.panelShoppingCartButttons.ResumeLayout(false);
            this.tabPageHistory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControlUser;
        public System.Windows.Forms.TabPage Purchase;
        public System.Windows.Forms.TabPage tabPageShoppingCart;
        public System.Windows.Forms.Panel panelShoppingCartButttons;
        public System.Windows.Forms.Button buttonBuy;
        public System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.Panel panelUser;
        public System.Windows.Forms.Panel panelShopingCart;
        public System.Windows.Forms.TabPage tabPageProfile;
        public System.Windows.Forms.Button buttonRefuse;
        public System.Windows.Forms.Button buttonApply;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.LinkLabel linkLabel;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        public System.Windows.Forms.TextBox textBoxCity;
        public System.Windows.Forms.TextBox textBoxUsername;
        public System.Windows.Forms.TextBox textBoxPassword2;
        public System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.TextBox textBoxLogin;
        public System.Windows.Forms.TabPage tabPageHistory;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dateTimePickerHistoryTo;
        public System.Windows.Forms.DateTimePicker dateTimePickerHistoryFrom;
        public System.Windows.Forms.Button buttonHystoryRefresh;
        public System.Windows.Forms.TreeView treeViewHistory;
    }
}

