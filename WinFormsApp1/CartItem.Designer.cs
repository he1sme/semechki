namespace WinFormsApp1
{
    partial class CartItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ItemPic = new Panel();
            cardItemTitle = new Label();
            cardItemPrice = new Label();
            panel1 = new Panel();
            counteritem = new Label();
            label3 = new Label();
            label4 = new Label();
            cartItemRemove = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemPic
            // 
            ItemPic.BackColor = Color.Black;
            ItemPic.Location = new Point(32, 27);
            ItemPic.Name = "ItemPic";
            ItemPic.Size = new Size(88, 89);
            ItemPic.TabIndex = 0;
            // 
            // cardItemTitle
            // 
            cardItemTitle.AutoSize = true;
            cardItemTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cardItemTitle.Location = new Point(155, 27);
            cardItemTitle.Name = "cardItemTitle";
            cardItemTitle.Size = new Size(37, 15);
            cardItemTitle.TabIndex = 1;
            cardItemTitle.Text = "label1";
            cardItemTitle.Click += label1_Click;
            // 
            // cardItemPrice
            // 
            cardItemPrice.AutoSize = true;
            cardItemPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cardItemPrice.Location = new Point(155, 68);
            cardItemPrice.Name = "cardItemPrice";
            cardItemPrice.Size = new Size(39, 15);
            cardItemPrice.TabIndex = 2;
            cardItemPrice.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(counteritem);
            panel1.Location = new Point(411, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(36, 37);
            panel1.TabIndex = 3;
            // 
            // counteritem
            // 
            counteritem.AutoSize = true;
            counteritem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            counteritem.Location = new Point(12, 13);
            counteritem.Name = "counteritem";
            counteritem.Size = new Size(12, 15);
            counteritem.TabIndex = 4;
            counteritem.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(453, 49);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 5;
            label3.Text = "+";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(363, 49);
            label4.Name = "label4";
            label4.Size = new Size(18, 28);
            label4.TabIndex = 6;
            label4.Text = "-";
            label4.Click += label4_Click;
            // 
            // cartItemRemove
            // 
            cartItemRemove.AutoSize = true;
            cartItemRemove.Font = new Font("Wide Latin", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cartItemRemove.Location = new Point(545, 57);
            cartItemRemove.Name = "cartItemRemove";
            cartItemRemove.Size = new Size(49, 29);
            cartItemRemove.TabIndex = 7;
            cartItemRemove.Text = "X";
            cartItemRemove.Click += CartRemove_Click;
            // 
            // CartItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 213, 147);
            Controls.Add(cartItemRemove);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(cardItemPrice);
            Controls.Add(cardItemTitle);
            Controls.Add(ItemPic);
            Margin = new Padding(0);
            Name = "CartItem";
            Size = new Size(601, 146);
            Load += CardItem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ItemPic;
        private Label cardItemTitle;
        private Label cardItemPrice;
        private Panel panel1;
        private Label label3;
        private Label counteritem;
        private Label label4;
        private Label cartItemRemove;
    }
}
