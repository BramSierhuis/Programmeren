using System;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter year (0 is stop value):");
                int year = int.Parse(Console.ReadLine());

                if (year == 0)
                {
                    Console.WriteLine("End of program");
                    return;
                }

                if(IsSchrikkelJaar(year))
                    Console.WriteLine(year + " is a leap year.");
                else
                    Console.WriteLine(year + " is not a leap year.");
            }
        }

        static bool IsSchrikkelJaar(int year)
        {
            if (year % 4 == 0 && year % 100 != 0)
                return true;
            else if (year % 4 == 0 && year % 400 == 0)
                return true;
            else
                return false;
        }
    }
}
