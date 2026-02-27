using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace WinFormsApp1
{
    public partial class CartItem : UserControl
    {

        internal event Action<CardItem>? OnCartDelete;

        public string title
        {
            get => cardItemTitle.Text;
            set => cardItemTitle.Text = value;
        }

        public string price
        {
            get => cardItemPrice.Text;
            set => cardItemPrice.Text = value;
        }

        public CartItem()
        {
            InitializeComponent();
        }

        private void CardItem_Load(object sender, EventArgs e)
        {
            int radius = 90;

            DatabaseController db = new DatabaseController();

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(ItemPic.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(ItemPic.Width - radius, ItemPic.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, ItemPic.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            ItemPic.Region = new Region(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CartRemove_Click(object sender, EventArgs e)
        {
            CardItem ci = new CardItem(cardItemTitle.Text.ToString(), int.Parse(cardItemPrice.Text));
            OnCartDelete?.Invoke(ci);
        }
    }
}
