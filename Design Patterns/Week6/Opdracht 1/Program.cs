using System;

namespace Opdracht_1
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
            Console.WriteLine("[shop creating expensive computers]");
            ComputerShop expensiveShop = new HighBudgetShop();
            expensiveShop.CreateComputer();

            Console.WriteLine();
            Console.WriteLine("[shop creating cheap computers]");
            ComputerShop cheapShop = new LowBudgetShop();
            cheapShop.CreateComputer();
        }
    }
}
