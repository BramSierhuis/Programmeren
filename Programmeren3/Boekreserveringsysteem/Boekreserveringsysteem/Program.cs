using System;
using Model;

namespace Boekreserveringsysteem
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Customer c = new Customer(1, "Bram", "Sierhuis", "bram@bramsierhuis.nl");
            Book b = new Book(1, "Harry Potter", "J. K. Rowling");
            Reservation r = new Reservation(1, c, b);

            Console.WriteLine(r.ToString());
        }
    }
}
