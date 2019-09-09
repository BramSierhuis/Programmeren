using System;
using System.Globalization;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lees het eerste getal uit
            Console.Write("Geef getal1: ");
            double getal1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Lees het tweede getal uit
            Console.Write("Geef getal2: ");
            double getal2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Lees het derde getal uit
            Console.Write("Geef getal3: ");
            double getal3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Berekn het gemiddelde van de 3
            double gemmiddelde = (getal1 + getal2 + getal3) / 3;

            //Toon het gemiddelde in de console
            Console.WriteLine("Gemiddelde: {0}", gemmiddelde);

            Console.ReadKey();
        }
    }
}
