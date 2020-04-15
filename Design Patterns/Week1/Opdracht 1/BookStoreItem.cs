using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public abstract class BookStoreItem
    {
        public string Title { get; set; }
        public float Price { get; set; }
        public int NumberOfItems { get; set; }

        public BookStoreItem(string title, float price, int numberOfItems)
        {
            Title = title;
            Price = price;
            NumberOfItems = numberOfItems;
        }
    }
}
