using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voer richtgetal in: ");
            int richtgetal = int.Parse(Console.ReadLine());
            int count = 0;

            while (true)
            {
                Console.Write("Voer getal in: ");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                    break;

                if (input == richtgetal)
                    count++;
            }

            Console.WriteLine("Het aantal getallen dat gelijk is aan het richtgetal is: " + count);

            Console.ReadKey();
        }
    }
}
