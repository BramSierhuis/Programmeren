using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opdracht2___Bioscoop
{
    public class Kaartje
    {
        int eersteZaal = 1;
        int laatsteZaal = 5;
        int[] minimumLeeftijden = { 0, 6, 9, 12, 16 };

        private string filmNaam;
        private int zaal;
        private DateTime aanvangstTijd;
        private int minimumLeeftijd;

        public string FilmNaam
        {
            get { return filmNaam; }
            set
            {
                if (value.Length > 0)
                    filmNaam = value;
                else
                    throw new Exception("De film moet een naam hebben");
            }
        }
        public int Zaal
        {
            get { return zaal; }
            set
            {
                if (value >= eersteZaal && value <= laatsteZaal)
                    zaal = value;
                else
                    throw new Exception("De opgegeven zaal moet bestaan");
            }
        }
        public DateTime AanvangstTijd
        {
            get { return aanvangstTijd; }
            set
            {
                if (value.Minute % 30 == 0)
                    aanvangstTijd = value;
                else
                    throw new Exception("De film kan enkel op hele of halve uren beginnen");
            }
        }
        public int MinimumLeeftijd
        {
            get { return minimumLeeftijd; }
            set
            {
                if (minimumLeeftijden.Contains(value))
                    minimumLeeftijd = value;
                else
                    throw new Exception("De film moet een geldige minimumleeftijd hebben");
            }
        }
        public double Prijs { get; set; }
        public bool RechtOpKorting
        {
            get 
            { 
                if (AanvangstTijd.DayOfWeek == DayOfWeek.Monday || AanvangstTijd.DayOfWeek == DayOfWeek.Tuesday)
                    return true;
                else
                    return false;
            }          
        }

        public Kaartje(string filmNaam, int zaal, DateTime aanvangstTijd, int minimumLeeftijd, double prijs)
        {
            FilmNaam = filmNaam;
            Zaal = zaal;
            AanvangstTijd = aanvangstTijd;
            MinimumLeeftijd = minimumLeeftijd;
            Prijs = prijs;

            Print();
        }

        public void Print()
        {
            Console.WriteLine("ticket aangemaakt voor '{4}', starttijd: {0}, prijs: {1}, zaal: {2} ({3}+)", AanvangstTijd, Prijs.ToString("0.00"), Zaal, MinimumLeeftijd, FilmNaam);
        }
    }
}
