using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Boekhandel
{
    public class BookStore
    {
        private List<Item> collection = new List<Item>();

        public void AddItem(Item item)
        {
            collection.Add(item);
        }

        public void PrintCollection()
        {
            double total = 0;

            foreach(Item item in collection)
            {
                item.Print();
                total += item.TotalPrice;
            }

            Console.WriteLine();
            Console.WriteLine("Total sales price: " + total.ToString("0.00"));
        }
    }
}
