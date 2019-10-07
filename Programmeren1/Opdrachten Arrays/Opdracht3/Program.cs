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

            Console.WriteLine();

            string[] namen = new string[size];
            double[] cijfers = new double[size];

            string topStudent = "";
            double max = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write("Geef de naam van de {0}e student: ", i + 1);
                namen[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                Console.Write("Geef het cijfer van {0}: ", namen[i]);

                double input = double.Parse(Console.ReadLine());
                cijfers[i] = input;

                if(input > max)
                {
                    max = input;
                    topStudent = namen[i];
                }
            }

            double avg = cijfers.Sum() / size;

            Console.WriteLine();
            Console.WriteLine("Het gemiddelde cijfer is: " + avg.ToString("0.00"));
            Console.WriteLine("Het hoogste cijfer is: {0} en dit is behaald door {1}", max, topStudent);
            Console.WriteLine();
            
            for(int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine("Student {0} heeft voor {1} een {2}", namen[i], name, cijfers[i]);
            }

            Console.ReadKey();
        }
    }
}
