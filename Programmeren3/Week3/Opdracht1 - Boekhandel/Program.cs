using System;

namespace Opdracht1___Boekhandel
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        void Start()
        {
            BookStore bruna = new BookStore();

            Book b1 = new Book("Dracula", "Bram Stoker", 15.00, 5);
            Book b2 = new Book("Joe speedboot", "Tom Wieringa", 12.50, 5);
            Book b3 = new Book("The Hobbit", "J.R.R. Tolkien", 3.90, 10);

            Magazine m1 = new Magazine("Time", Enums.Days.Friday, 2.50, 8);
            Magazine m2 = new Magazine("Donald Duck", Enums.Days.Monday, 12.50, 4);

            bruna.AddItem(b1);
            bruna.AddItem(b2);
            bruna.AddItem(b3);
            bruna.AddItem(m1);
            bruna.AddItem(m2);

            bruna.PrintCollection();
        }
    }
}
