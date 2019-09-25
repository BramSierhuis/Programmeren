using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht5
{
    class Opdracht5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            if(number1 % number2 == 0)
                Console.WriteLine("{0} is een veelvoud van {1}", number1, number2);
            else if( number2 % number1 == 0)
                Console.WriteLine("{0} is een veelvoud van {1}", number2, number1);
            else
                Console.WriteLine("Deze nummers zijn geen veelvoudt van elkaar.");

            Console.ReadKey();
        }
    }
}
