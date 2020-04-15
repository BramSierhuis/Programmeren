using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class Book : BookStoreItem
    {
        public string Author { get; set; }

        public Book(string author, string title, float price, int numberOfItems) : base(title, price, numberOfItems)
        {
            Author = author;
        }

        public override string ToString()
        {
            return string.Format("[Book] {0} - {1}, {2} ({3}x)", Author, Title, Price.ToString("0.00"), NumberOfItems);
        }
    }
}
