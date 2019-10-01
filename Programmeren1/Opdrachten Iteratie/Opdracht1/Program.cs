using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            double totaal = 0;
            double count = 0;

            while (true)
            {
                Console.Write("Voer getal in: ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                    break;

                if (input > 0)
                {
                    totaal += input;
                    count++;
                }
            }

            double gem = totaal / count;

            if (totaal == 0)
                gem = 0;

            Console.WriteLine("Het gemiddelde van de positieve getallen is: " + gem.ToString("0.00"));

            Console.ReadKey();
        }
    }
}
