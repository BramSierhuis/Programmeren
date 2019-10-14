using System;

namespace Opdracht4
{
    class Program
    {

        static void Main(string[] args)
        {
            int aantalPunten, aantalKommas, aantalPuntKommas;

            Console.Write("Enter a text> ");
            string input = Console.ReadLine();

            OnderzoekTekst(input, out aantalPunten, out aantalKommas, out aantalPuntKommas);

            Console.WriteLine("Result: {0} full stops, {1} commas, {2} semicolons.", aantalPunten, aantalKommas, aantalPuntKommas);
        }

        static void OnderzoekTekst(string input, out int aantalPunten, out int aantalKommas, out int aantalPuntKommas)
        {
            aantalPunten = input.Split('.').Length - 1;
            aantalKommas = input.Split(',').Length - 1;
            aantalPuntKommas = input.Split(';').Length - 1;
        }
    }
}
