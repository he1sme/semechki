namespace WinFormsApp1
{
    partial class UserControl2
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
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            navbar = new Panel();
            cart_btn = new Label();
            panel1 = new Panel();
            food_btn = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            navbar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(156, 52);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 3;
            label2.Text = "SUSHI FOOD";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 213, 147);
            panel2.ForeColor = Color.FromArgb(247, 213, 147);
            panel2.Location = new Point(156, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 3);
            panel2.TabIndex = 4;
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
            // navbar
            // 
            navbar.BackColor = Color.Black;
            navbar.Controls.Add(cart_btn);
            navbar.Controls.Add(label1);
            navbar.Location = new Point(40, 43);
            navbar.Name = "navbar";
            navbar.Size = new Size(84, 542);
            navbar.TabIndex = 5;
            // 
            // cart_btn
            // 
            cart_btn.AutoSize = true;
            cart_btn.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cart_btn.ForeColor = Color.FromArgb(241, 213, 147);
            cart_btn.Location = new Point(19, 259);
            cart_btn.Name = "cart_btn";
            cart_btn.Size = new Size(55, 47);
            cart_btn.TabIndex = 3;
            cart_btn.Text = "К.";
            cart_btn.Click += onCart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 213, 147);
            panel1.Controls.Add(food_btn);
            panel1.Location = new Point(40, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(84, 74);
            panel1.TabIndex = 1;
            // 
            // food_btn
            // 
            food_btn.AutoSize = true;
            food_btn.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            food_btn.ForeColor = Color.Black;
            food_btn.Location = new Point(20, 12);
            food_btn.Name = "food_btn";
            food_btn.Size = new Size(50, 47);
            food_btn.TabIndex = 2;
            food_btn.Text = "Е.";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(156, 105);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1082, 480);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(navbar);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "UserControl2";
            Size = new Size(1254, 661);
            Load += UserControl2_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private Label label1;
        private Panel navbar;
        private Panel panel1;
        private Label food_btn;
        private Label cart_btn;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
