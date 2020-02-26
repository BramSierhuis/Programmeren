using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Boekhandel
{
    public class Book : Item
    {
        public string Author { get; }

        public Book(string title, string author, double price) : base(title, price)
        {
            Author = author;
        }

        public override void Print()
        {
            Console.WriteLine("[Book] '{0}' by {1}, ${2} ({3}x)", Title, Author, Price.ToString("0.00"), Count);
        }
    }
}
