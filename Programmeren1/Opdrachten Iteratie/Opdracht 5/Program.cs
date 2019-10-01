using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Voer jaartal in: ");
                int jaartal = int.Parse(Console.ReadLine());

                if (jaartal == 0)
                    break;

                if (jaartal < 0)
                    Console.WriteLine("Een jaartal kan geen negatief getal zijn. Probeer opnieuw");
                else if ((jaartal % 400 == 0 || jaartal % 4 == 0) && jaartal % 100 != 0)
                    Console.WriteLine(jaartal + " is een schrikkeljaar.");
                else if(jaartal == 2000)
                    Console.WriteLine(jaartal + " is bij uitzondering ook een schrikkeljaar.");
                else
                    Console.WriteLine(jaartal + " is geen schrikkeljaar.");
            }

            Console.ReadKey();
        }
    }
}
