using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class Cart
    {
        public List<CardItem> list;

        public Cart()
        {
            list = new List<CardItem>();
        }

        public CardItem? add(CardItem item)
        {
            foreach (CardItem item2 in list)
            {
                if (item2.name == item.name)
                {
                    return null;
                }
            }
            list.Add(item);
            return item;
        }

        public CardItem? remove(CardItem item)
        {
            foreach (CardItem item2 in list)
            {
                if (item2.name == item.name)
                {
                    list.Remove(item2);
                    return item;
                }
            }
            return null;
            
        }

        public List<CardItem> getList()
        {
            return list;
        }

    }
}
