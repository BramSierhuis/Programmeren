using System;
using System.Globalization;

namespace Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lees de invoer van het aantal seconden uit
            Console.Write("Geef aantal seconden: ");
            int seconden = int.Parse(Console.ReadLine());

            //Bereken het aantal hele uren en trek dit van het aantal secondes af
            int uren = seconden / 3600;
            seconden -= uren * 3600;

            //Bereken het aantal hele minuten van de overgebleven seconden en trek dit van de rest van de seconden af
            int minuten = seconden / 60;
            seconden -= minuten * 60;

            //Toon de bereknde tijden in de console. Er staan altijd 2 getallen om de waarden weer te geven
            Console.WriteLine("{0}:{1}:{2}", uren.ToString("00"), minuten.ToString("00"), seconden.ToString("00"));

            Console.ReadKey();
        }
    }
}
