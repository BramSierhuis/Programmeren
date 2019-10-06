using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            double total = 0;
            Random random = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(200);

                Console.WriteLine("Element {0} is {1}", i, numbers[i]);
            }

            foreach(int i in numbers)
            {
                total += i;
            }

            double avg = total / numbers.Length;

            Console.WriteLine();
            Console.WriteLine("Het gemiddelde is " + avg);
            Console.WriteLine();

            for(int i = 0; i < numbers.Length; i++)
            {
                double dif = Math.Abs(numbers[i] - avg);

                Console.WriteLine("Verschil gemiddelde en element {0} is {1}", i, dif.ToString("0.00"));
            }

            Console.ReadKey();
        }
    }
}
