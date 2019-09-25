using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    class Opdracht4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine());

            int som = number1 + number2 + number3;
            double gemiddelde = som / 3;
            int product = number1 * number2 * number3;
            int grootste = 0;
            int kleinste = 0;

            if(number1 > number2 && number1 > number3)
            {
                grootste = number1;

                if (number2 > number3)
                    kleinste = number3;
                else if (number2 < number3)
                    kleinste = number2;
            }else if(number2 > number1 && number2 > number3)
            {
                grootste = number2;

                if (number1 > number3)
                    kleinste = number3;
                else if (number1 < number3)
                    kleinste = number1;
            }else if(number3 > number1 && number3 > number2)
            {
                grootste = number3;

                if (number2 > number1)
                    kleinste = number1;
                else if (number2 < number1)
                    kleinste = number2;
            }
            else
            {
                Console.WriteLine("Hey! You didn't make my creator teach me how to handle this input!");
                Console.WriteLine("Im lazy so i'll just display some 0's");
                return;
            }

            Console.WriteLine("sum = " + som);
            Console.WriteLine("gemiddelde = " + gemiddelde);
            Console.WriteLine("product = " + product);
            Console.WriteLine("hoogste = " + grootste);
            Console.ReadKey();
        }
    }
}