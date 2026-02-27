namespace WinFormsApp1
{
    partial class UserControl1
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
            cart_btn = new Label();
            food_btn = new Label();
            panel1 = new Panel();
            label1 = new Label();
            navbar2 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            cartLayout = new FlowLayoutPanel();
            panel1.SuspendLayout();
            navbar2.SuspendLayout();
            SuspendLayout();
            // 
            // cart_btn
            // 
            cart_btn.AutoSize = true;
            cart_btn.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cart_btn.ForeColor = Color.Black;
            cart_btn.Location = new Point(19, 11);
            cart_btn.Name = "cart_btn";
            cart_btn.Size = new Size(55, 47);
            cart_btn.TabIndex = 3;
            cart_btn.Text = "К.";
            // 
            // food_btn
            // 
            food_btn.AutoSize = true;
            food_btn.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            food_btn.ForeColor = Color.FromArgb(241, 213, 147);
            food_btn.Location = new Point(20, 169);
            food_btn.Name = "food_btn";
            food_btn.Size = new Size(50, 47);
            food_btn.TabIndex = 2;
            food_btn.Text = "Е.";
            food_btn.Click += FoodBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 213, 147);
            panel1.Controls.Add(cart_btn);
            panel1.Location = new Point(0, 248);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 74);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(241, 213, 147);
            label1.Location = new Point(19, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 47);
            label1.TabIndex = 1;
            label1.Text = "S.";
            // 
            // navbar2
            // 
            navbar2.BackColor = Color.Black;
            navbar2.Controls.Add(food_btn);
            navbar2.Controls.Add(panel1);
            navbar2.Controls.Add(label1);
            navbar2.Location = new Point(40, 43);
            navbar2.Name = "navbar2";
            navbar2.Size = new Size(84, 542);
            navbar2.TabIndex = 2;
            navbar2.Paint += navbar2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(156, 52);
            label2.Name = "label2";
            label2.Size = new Size(72, 32);
            label2.TabIndex = 5;
            label2.Text = "CART";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 213, 147);
            panel2.ForeColor = Color.FromArgb(247, 213, 147);
            panel2.Location = new Point(156, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 3);
            panel2.TabIndex = 6;
            // 
            // cartLayout
            // 
            cartLayout.AutoScroll = true;
            cartLayout.Location = new Point(156, 110);
            cartLayout.Name = "cartLayout";
            cartLayout.Size = new Size(738, 429);
            cartLayout.TabIndex = 7;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cartLayout);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(navbar2);
            Name = "UserControl1";
            Size = new Size(1254, 661);
            Load += UserControl1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            navbar2.ResumeLayout(false);
            navbar2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cart_btn;
        private Label food_btn;
        private Panel panel1;
        private Label label1;
        private Panel navbar2;
        private Label label2;
        private Panel panel2;
        private FlowLayoutPanel cartLayout;
    }
}
