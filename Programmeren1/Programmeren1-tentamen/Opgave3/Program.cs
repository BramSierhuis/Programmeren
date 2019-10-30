using System;

namespace Opgave3
{
    class Program
    {
        /* Volgensmij klopt de vraagstelling bij deze vraag niet helemaal.
         * U geeft namelijk aan dat we een array moeten maken met waarden tussen de 1 en de 100,
         * maar in het voorbeeld liggen de waarden tussen de ingevoerde min en max.
         * Ik wist niet zeker welk van de twee u wilde, dus ik heb er voor gekozen om van de 1 en de 100 uit te gaan. */

        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 20;
            const int MIN = 1;
            const int MAX = 100; //De max is 100 ipv van 99 omdat anders de maximaal gegenereerde waarde 98 is

            Random rnd = new Random();

            int[] numbers = new int[ARRAY_SIZE];

            Console.Write("Minimum value: ");
            int minimumValue = int.Parse(Console.ReadLine());
            
            Console.Write("Maximum value: ");
            int maximumValue = int.Parse(Console.ReadLine());

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(MIN, MAX);
            }

            foreach(int num in numbers)
            {
                if (num > minimumValue + 20 && num < maximumValue - 20)
                    Console.ForegroundColor = ConsoleColor.Green;
                else if (num > minimumValue + 10 && num < maximumValue - 10)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadLine();
        }
    }
}
