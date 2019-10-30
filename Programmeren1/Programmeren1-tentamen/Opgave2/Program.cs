using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Voer een getal in: ");
                int input = int.Parse(Console.ReadLine());

                if (input < 1)
                    break;

                int factor = 2;
                while (input > 1)
                {
                    if (input % factor == 0)
                    {
                        Console.Write(factor + " ");

                        input = input / factor;
                    } 
                    else
                        factor++;
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadLine();
        }
    }
}
