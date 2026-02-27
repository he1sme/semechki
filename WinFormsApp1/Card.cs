using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Card : UserControl
    {
        internal event Action<CardItem>? onAddCart;

        public string CardTitle
        {
            get => card_name.Text;
            set => card_name.Text = value;
        }

        public Card()
        {
            InitializeComponent();

        }

        private void Card_Load(object sender, EventArgs e)
        {

        }

        private void card_name_Click(object sender, EventArgs e)
        {

        }

        private void onProduct_Click(object sender, EventArgs e)
        {
            CardItem ct = new CardItem(CardTitle.ToString(), 1);
            onAddCart?.Invoke(ct);
        }
    }
}
