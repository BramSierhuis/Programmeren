using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht6
{
    class Opdracht6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (score)
            {
                case int n when (n >= 90 && n <= 100):
                    Console.WriteLine("Grade: A");
                    break;
                case int n when (n >= 80 && n <= 89):
                    Console.WriteLine("Grade: B");
                    break;
                case int n when (n >= 70 && n <= 79):
                    Console.WriteLine("Grade: C");
                    break;
                case int n when (n >= 60 && n <= 69):
                    Console.WriteLine("Grade: D");
                    break;
                case int n when (n >= 0 && n < 60):
                    Console.WriteLine("Grade: F");
                    break;
                default:
                    Console.WriteLine("Invalid score entered");
                    break;
            }

            if (score >= 70)
                Console.WriteLine("Course passed");
            else
                Console.WriteLine("Course not passed");

            Console.ReadLine();
        }
    }
}
