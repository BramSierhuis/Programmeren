using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;

            Random rnd = new Random();

            for(int i = 0; i < SIZE; i++)
            {
                int getal1 = rnd.Next(1, 51);
                int getal2 = rnd.Next(1, 6);
                
                int rest;
                int quotient = IntegerDeling(getal1, getal2, out rest);

                Console.WriteLine("{0} / {1} = {2} ({3})", getal1, getal2, quotient, rest);
            }

            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadLine();
        }

        static int IntegerDeling(int getal1, int getal2, out int rest)
        {
            int quotient = 0;
            while(getal1 - getal2 >= 0)
            {
                getal1 -= getal2;
                quotient++;
            }

            rest = getal1;
            return quotient;
        }
    }
}
