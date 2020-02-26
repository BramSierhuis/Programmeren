using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2___Bioscoop
{
    public class Klant
    {
        private int maxAge = 150;
        private int daysForDiscount = 50;

        private string naam;
        private DateTime geboorteDatum;

        public int Leeftijd {
            get 
            {
                int leeftijd = DateTime.Today.Year - GeboorteDatum.Year;
                if (DateTime.Now.DayOfYear < GeboorteDatum.DayOfYear)
                    leeftijd--;

                return leeftijd;
            } 
        }
        public bool RechtOpKorting 
        {
            get 
            {
                if (DateTime.Today.Day - InschijfDatum.Day > daysForDiscount)
                    return true;
                return false;
            } 
        }

        public string Naam 
        {
            get { return naam; }
            set {
                if (value.Length > 0)
                    naam = value;
                else
                    throw new Exception("Een klant moet een naam hebben");
                } 
        }
        public DateTime InschijfDatum { get; }
        public DateTime GeboorteDatum
        {
            get { return geboorteDatum; }
            set
            {
                if (DateTime.Today.Year - value.Year < maxAge && DateTime.Today.Year - value.Year > 0)
                    geboorteDatum = value;
                else
                    throw new Exception("Voor een geldig geboortejaar in");
            }
        }

        public Klant(string naam, DateTime geboorteDatum)
        {
            Naam = naam;
            GeboorteDatum = geboorteDatum;
            InschijfDatum = DateTime.Today;
        }

        public void PrintKlant()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Naam);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Geboortedatum: " + GeboorteDatum.ToShortDateString());
            Console.WriteLine("Leeftijd: " + Leeftijd);
            Console.WriteLine("Inschrijfdatum: " + InschijfDatum.ToShortDateString());
            Console.WriteLine("Recht op korting: " + RechtOpKorting.ToString());
        }
    }
}
