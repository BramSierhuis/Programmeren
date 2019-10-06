using System;
using System.Linq;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de vaknaam: ");
            string name = Console.ReadLine();

            Console.Write("Geef het aantal studenten: ");
            int size = int.Parse(Console.ReadLine());

            string[] namen = new string[size];
            double[] cijfers = new double[size];

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Geef de naam van de {0}e student: ", i);
                namen[i] = Console.ReadLine();
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Geef het cijfer van {0}: ", namen[i]);
                cijfers[i] = double.Parse(Console.ReadLine());
            }

            double avg = cijfers.Sum() / size;

            Console.WriteLine();
            Console.WriteLine("Het gemiddelde cijfer is: " + avg);
            Console.WriteLine("Het hoogste cijfer is: " + cijfers.Max());

        }
    }
}
