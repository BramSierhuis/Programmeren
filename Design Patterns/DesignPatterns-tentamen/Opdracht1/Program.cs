using System;

namespace Opdracht1
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
            Console.WriteLine("[csv data]");
            DataVerwerker csvVerwerker = new CSVDataVerwerker();
            csvVerwerker.VerwerkData();
            Console.WriteLine();
            Console.WriteLine("[database data]");
            DataVerwerker databaseVerwerker = new DatabaseDataVerwerker();
            databaseVerwerker.VerwerkData();
            Console.ReadKey();
        }
    }
}