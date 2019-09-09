using System;
using System.Globalization;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef prijs: ");

            //Afhankelijk van de taal van de computer moet de input een punt of een komma zijn. Als de computer engels is
            //een punt, is hij nederlands een komma. Mijn computer staat op engels, dus ik kan het niet testen met nederlands.
            //Ik denk overigens dat ik het zo opgelost heb

            //Krijg de ingevoerde prijs
            double prijs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double btw = Math.Round(prijs * 0.21, 2); //Bereken de btw
            double totaal = Math.Round(btw + prijs, 2); //Bereken de totaalprijs

            //Toon de berekende waardes in de console
            Console.WriteLine("Prijs: {0}, btw: {1}, totaal: {2}", prijs, btw, totaal);

            Console.ReadKey();
        }
    }
}
