using System;
using System.Globalization;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef aantal seconden: ");
            int seconden = int.Parse(Console.ReadLine());

            int uren = seconden / 3600;
            seconden -= uren * 3600;

            int minuten = seconden / 60;
            seconden -= minuten * 60;

            Console.WriteLine("{0}:{1}:{2}", uren.ToString("00"), minuten.ToString("00"), seconden.ToString("00"));

            Console.ReadKey();
        }
    }
}
