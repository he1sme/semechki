namespace WinFormsApp1
{
    partial class Card
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
            panel1 = new Panel();
            card_name = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 162);
            panel1.TabIndex = 0;
            panel1.Click += onProduct_Click;
            // 
            // card_name
            // 
            card_name.AutoSize = true;
            card_name.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            card_name.Location = new Point(13, 177);
            card_name.Name = "card_name";
            card_name.Size = new Size(66, 30);
            card_name.TabIndex = 1;
            card_name.Text = "label1";
            card_name.Click += card_name_Click;
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(card_name);
            Controls.Add(panel1);
            Name = "Card";
            Size = new Size(228, 234);
            Load += Card_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label card_name;
    }
}
