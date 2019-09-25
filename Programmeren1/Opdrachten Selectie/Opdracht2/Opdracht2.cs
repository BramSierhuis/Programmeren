using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Opdracht2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1..4): ");
            int number = int.Parse(Console.ReadLine());

            switch (number) {
                case 1:
                    Console.WriteLine("Klaveren");
                    break;
                case 2:
                    Console.WriteLine("Ruiten");
                    break;
                case 3:
                    Console.WriteLine("Harten");
                    break;
                case 4:
                    Console.WriteLine("Schoppen");
                    break;
                default:
                    Console.WriteLine("Incorrect number!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
