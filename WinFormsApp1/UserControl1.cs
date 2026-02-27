using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserControl1 : UserControl
    {

        public event Action OnBack;
        internal List<CardItem> CartItems;
        internal event Action<CardItem>? OnCartDelete;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(navbar2.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(navbar2.Width - radius, navbar2.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, navbar2.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            for (int i = 0; i < CartItems.Count; i++)
            {
                var cartItem = new CartItem();
                cartItem.title = CartItems[i].name.ToString();
                cartItem.price = CartItems[i].cash.ToString();

                cartItem.OnCartDelete += card =>
                {
                    OnCartDelete?.Invoke(card);
                };
                cartLayout.Controls.Add(cartItem);
            }

            navbar2.Region = new Region(path);
        }

        private void FoodBtn_Click(object sender, EventArgs e)
        {
            OnBack?.Invoke();
        }

        private void navbar2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
