using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class CardItem
    {
        String name_t;
        int cash_t;
        String image_url;

        public CardItem(String name, int cash, string image_url = "")
        {
            name_t = name;
            cash_t = cash;
            this.image_url = image_url;
        }

        public string name
        {
            get => name_t;
            set => name_t = value;
        }

        public int cash
        {
            get => cash_t;
            set => cash_t = value;
        }

        public string image
        {
            get => image_url;
            set => image_url = value;
        }

    }
}
