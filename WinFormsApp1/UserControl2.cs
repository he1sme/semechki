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
    public partial class UserControl2 : UserControl
    {

        public event Action onCart;
        internal event Action<CardItem>? onAddCart2;

        DatabaseController db = new DatabaseController();

        List<CardItem> cards;

        public UserControl2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            int radius = 30;

            DatabaseController db = new DatabaseController();

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(navbar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(navbar.Width - radius, navbar.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, navbar.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            navbar.Region = new Region(path);
            cards = db.GetAllDishes();


            for (int i = 0; i < cards.Count; i++)
            {
                var card = new Card();
                card.CardTitle = cards[i].name;
                
                //CardItem ci = new CardItem(card.CardTitle, 0);
                card.onAddCart += card =>
                {
                    onAddCart2?.Invoke(card);
                    
                };
                flowLayoutPanel1.Controls.Add(card);

            }

            db.GetAllDishes();
        }

        private void onCart_Click(object sender, EventArgs e)
        {
            onCart?.Invoke();
        }

    }
}
