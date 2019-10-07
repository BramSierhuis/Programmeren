using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            int count = 0;
            int[] numbers = new int[20];

            while (input != 0 && count < 20)
            {
                Console.Write("Geef een getal: (0 is exit)");
                input = int.Parse(Console.ReadLine());

                numbers[count] = input;
                count++;
            }

            Console.WriteLine();
            Console.Write("Geef de zoekwaarde: ");
            int zoekwaarde = int.Parse(Console.ReadLine());
            int voorkomen = 0;

            foreach(int number in numbers)
            {
                if (number == zoekwaarde)
                    voorkomen++;
            }

            Console.WriteLine("De zoekwaarde komt {0} keer voor", voorkomen);

            Console.ReadKey();
        }
    }
}
