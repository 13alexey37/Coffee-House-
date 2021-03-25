
namespace CoffeeShop.view
{
    partial class FormExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExample));
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.labelProductAmount = new System.Windows.Forms.Label();
            this.labelProductInfo = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.pictureBoxProductImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelShoppingCartAmount = new System.Windows.Forms.Label();
            this.groupBoxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.numericUpDown1);
            this.groupBoxProduct.Controls.Add(this.button1);
            this.groupBoxProduct.Controls.Add(this.labelProductAmount);
            this.groupBoxProduct.Controls.Add(this.labelShoppingCartAmount);
            this.groupBoxProduct.Controls.Add(this.labelProductInfo);
            this.groupBoxProduct.Controls.Add(this.labelProductPrice);
            this.groupBoxProduct.Controls.Add(this.pictureBoxProductImage);
            this.groupBoxProduct.Location = new System.Drawing.Point(10, 46);
            this.groupBoxProduct.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProduct.Size = new System.Drawing.Size(548, 105);
            this.groupBoxProduct.TabIndex = 0;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "groupBox1";
            // 
            // labelProductAmount
            // 
            this.labelProductAmount.AutoSize = true;
            this.labelProductAmount.Location = new System.Drawing.Point(92, 32);
            this.labelProductAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductAmount.Name = "labelProductAmount";
            this.labelProductAmount.Size = new System.Drawing.Size(79, 13);
            this.labelProductAmount.TabIndex = 4;
            this.labelProductAmount.Text = "Нет в наличии";
            // 
            // labelProductInfo
            // 
            this.labelProductInfo.AutoSize = true;
            this.labelProductInfo.Location = new System.Drawing.Point(92, 46);
            this.labelProductInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductInfo.Name = "labelProductInfo";
            this.labelProductInfo.Size = new System.Drawing.Size(77, 13);
            this.labelProductInfo.TabIndex = 3;
            this.labelProductInfo.Text = "Без описания";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(92, 18);
            this.labelProductPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(92, 13);
            this.labelProductPrice.TabIndex = 2;
            this.labelProductPrice.Text = "Цена не указана";
            // 
            // pictureBoxProductImage
            // 
            this.pictureBoxProductImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxProductImage.BackgroundImage")));
            this.pictureBoxProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProductImage.Location = new System.Drawing.Point(5, 18);
            this.pictureBoxProductImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProductImage.Name = "pictureBoxProductImage";
            this.pictureBoxProductImage.Size = new System.Drawing.Size(82, 82);
            this.pictureBoxProductImage.TabIndex = 0;
            this.pictureBoxProductImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить в корзину";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(466, 61);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // labelShoppingCartAmount
            // 
            this.labelShoppingCartAmount.AutoSize = true;
            this.labelShoppingCartAmount.Location = new System.Drawing.Point(441, 84);
            this.labelShoppingCartAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShoppingCartAmount.Name = "labelShoppingCartAmount";
            this.labelShoppingCartAmount.Size = new System.Drawing.Size(95, 13);
            this.labelShoppingCartAmount.TabIndex = 3;
            this.labelShoppingCartAmount.Text = "Уже в корзине: 0";
            // 
            // FormExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBoxProduct);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormExample";
            this.Text = "FormExample";
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.GroupBox groupBoxProduct;
		internal System.Windows.Forms.PictureBox pictureBoxProductImage;
		internal System.Windows.Forms.Label labelProductAmount;
		internal System.Windows.Forms.Label labelProductInfo;
		internal System.Windows.Forms.Label labelProductPrice;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label labelShoppingCartAmount;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}