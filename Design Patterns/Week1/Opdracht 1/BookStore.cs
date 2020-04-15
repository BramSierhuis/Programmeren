using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class BookStore
    {
        private List<BookStoreItem> items = new List<BookStoreItem>();

        public void Add(BookStoreItem item)
        {
            items.Add(item);
        }

        public void PrintAllItems()
        {
            foreach(BookStoreItem item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
