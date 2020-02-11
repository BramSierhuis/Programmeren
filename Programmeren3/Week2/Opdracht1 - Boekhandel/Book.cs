using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Boekhandel
{
    public class Book : Item
    {
        string author;

        public Book(string title, string author, double price) : base(title, price)
        {
            this.author = author;
        }

        public override void Print()
        {
            Console.WriteLine("[Book] '{0}' by {1}, ${2}", title, author, price.ToString("0.00"));
        }
    }
}
