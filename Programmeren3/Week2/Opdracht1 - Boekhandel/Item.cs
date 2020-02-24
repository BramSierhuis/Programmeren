using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Boekhandel
{
    public abstract class Item
    {
        public string title;
        public double price;

        public Item(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public virtual void Print() { }
    }
}
