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
            const int ARRAY_SIZE = 20; //De grootte van de array
            const int MIN = 1; //Het laagste getal dat kan worden gegenereerd
            const int MAX = 100; //De max is 100 ipv van 99 omdat anders de maximaal gegenereerde waarde 98 is

            Random rnd = new Random(); //De random die gebruikt wordt voor het genereren van random getallen

            int[] numbers = new int[ARRAY_SIZE]; //De array met getallen

            Console.Write("Minimum value: ");
            int minimumValue = int.Parse(Console.ReadLine()); //De minimumwaarde die gebruikt wordt als criteria voor de kleuren
            
            Console.Write("Maximum value: ");
            int maximumValue = int.Parse(Console.ReadLine()); //De maximumwaarde die gebruikt wordt als criteria voor de kleuren

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(MIN, MAX); //Vul de array met random getallen
            }

            foreach(int num in numbers) //Geef elk getal in de array een kleur door hem met een steeds specifieker bereik te vergelijken
            {
                if (num > minimumValue + 20 && num < maximumValue - 20) //Kijken of het getal binnen het bereik valt
                    Console.ForegroundColor = ConsoleColor.Green;       //Verander de kleur van de console
                else if (num > minimumValue + 10 && num < maximumValue - 10)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                else
                    Console.ForegroundColor = ConsoleColor.Red;

                Console.Write(num + " "); //Zet het getal in de console, de kleur waarmee dit gebeurd is al ingesteld
            }

            Console.ForegroundColor = ConsoleColor.Gray; //Reset de kleur van de console

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadLine();
        }
    }
}
