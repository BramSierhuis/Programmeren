using System;
using System.Linq;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(150);

                Console.WriteLine("Element {0} is {1}", i, numbers[i]);
            }

            int smallest = numbers.Min();
            int count = 0;

            foreach (int i in numbers)
            {
                if (i == smallest)
                    count++;
            }

            Console.WriteLine();
            Console.WriteLine("The smallest number is {0} and it occured {1} times", smallest, count);

            Console.ReadKey();
        }
    }
}
