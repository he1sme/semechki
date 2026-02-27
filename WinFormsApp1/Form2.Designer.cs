namespace WinFormsApp1
{
    partial class Form2
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
            navbar = new Panel();
            panel1 = new Panel();
            food_btn = new Label();
            cart_btn = new Label();
            label1 = new Label();
            navbar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.BackColor = Color.Black;
            navbar.Controls.Add(food_btn);
            navbar.Controls.Add(panel1);
            navbar.Controls.Add(label1);
            navbar.Location = new Point(25, 27);
            navbar.Name = "navbar";
            navbar.Size = new Size(84, 507);
            navbar.TabIndex = 1;
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
            // food_btn
            // 
            food_btn.AutoSize = true;
            food_btn.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            food_btn.ForeColor = Color.FromArgb(241, 213, 147);
            food_btn.Location = new Point(19, 174);
            food_btn.Name = "food_btn";
            food_btn.Size = new Size(50, 47);
            food_btn.TabIndex = 2;
            food_btn.Text = "Е.";
            food_btn.Click += food_btn_Click;
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
            cart_btn.Click += cart_btn_Click;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 568);
            Controls.Add(navbar);
            Name = "Form2";
            Text = "Form2";
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel navbar;
        private Panel panel1;
        private Label food_btn;
        private Label cart_btn;
        private Label label1;
    }
}