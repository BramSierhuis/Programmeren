using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        private void Start()
        {
            //A single shop is created because it can use different factory's
            ComputerShop shop = new ComputerShop();

            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            ComputerFactory expensiveFactory = new HighBudgetFactory();
            shop.CreateComputer(expensiveFactory);

            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            ComputerFactory cheapFactory = new LowBudgetFactory();
            shop.CreateComputer(cheapFactory);
        }
    }
}
