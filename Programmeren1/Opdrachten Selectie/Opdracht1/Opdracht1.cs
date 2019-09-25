using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    class Opdracht1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (number1 > number2)
            {
                Console.WriteLine("The biggest number is: {0}", number1);
                Console.WriteLine("The smallest number is: {0}", number2);
            } else if(number2 > number1)
            {
                Console.WriteLine("The biggest number is: {0}", number2);
                Console.WriteLine("The smallest number is: {0}", number1);
            }
            else if(number1 == number2)
            {
                Console.WriteLine("The numbers are the same");
            }

            Console.ReadKey();
        }
    }
}
