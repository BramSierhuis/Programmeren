using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            double som = 0;
            double count = 0;

            while (true)
            {
                Console.Write("Voer getal in: ");
                int input = int.Parse(Console.ReadLine());

                count++;

                if (input == 0)
                    break;

                if (count % 5 == 0)              
                    som += input;
            }

            Console.WriteLine("De som van het 5-de, 10-de, 15-de, ... getal is: " + som);

            Console.ReadKey();
        }
    }
}
