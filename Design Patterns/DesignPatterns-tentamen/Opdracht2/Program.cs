using System;

namespace Opdracht2
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
            PersoneelsLid manager = new Manager("Theo de Groot");
            manager.Betaal(580.0f);
            PersoneelsLid accountant = new Accountant("Bas Dijkstra");
            accountant.Betaal(340.00f);
            // wijzig betaalwijze van accountant
            accountant.BetaalWijze = new PayPalBetaling();
            accountant.Betaal(179.50f);
            Console.ReadKey();
        }
    }
}
