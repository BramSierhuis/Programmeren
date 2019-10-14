using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true){
                Console.Write("Enter number (0 is stop value):");
                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    Console.WriteLine("End of program");
                    return;
                }

                if (input > 0)
                {
                    if (IsPriemGetal(input))
                        Console.WriteLine(input + " is a prime number.");
                    else
                        Console.WriteLine(input + " isn't a prime number.");
                }
                else
                    Console.WriteLine(input + " is a negative number.");
            }
        }

        static bool IsPriemGetal(int number)
        {
            bool isPrime = true;
            int i = 2;

            while((i < number) && isPrime)
            {
                if ((number % i) == 0)
                    isPrime = false;
                else
                    i++;
            }

            return isPrime;
        }
    }
}
