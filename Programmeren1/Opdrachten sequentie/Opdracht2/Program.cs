using System;
using System.Globalization;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef getal1: ");
            double getal1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Geef getal2: ");
            double getal2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Geef getal3: ");
            double getal3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double gemmiddelde = (getal1 + getal2 + getal3) / 3;

            Console.WriteLine("Gemiddelde: {0}", gemmiddelde);

            Console.ReadKey();
        }
    }
}
