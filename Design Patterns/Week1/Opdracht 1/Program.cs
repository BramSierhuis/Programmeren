using System;

namespace Opdracht_1
{
    class Program
    {
        private BookStore store = new BookStore();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        private void Start()
        {
            store.Add(new Book("Bram Stoker", "Dracula", 15f, 5));
            store.Add(new Book("Tommy Wieringa", "Joe speedboot", 12.50f, 3));
            store.Add(new Magazine(DayOfWeek.Thursday, "Time", 3.90f, 10));
            store.Add(new CD("The Cure", "Seventeen Seconds", 2.50f, 5));

            store.PrintAllItems();
        }
    }
}
