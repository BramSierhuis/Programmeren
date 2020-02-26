using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2___Bioscoop
{
    public class Reservering
    {
        double kaartjeKorting = 0.05;
        double klantKorting = 0.1;

        public Klant Klant { get; set; }
        public List<Kaartje> Kaartjes { get; set; }
        public double TotaalPrijs
        {
            get 
            {
                double totaal = 0;

                foreach(Kaartje kaartje in Kaartjes)
                {
                    if (Klant.Leeftijd < kaartje.MinimumLeeftijd)
                        throw new Exception("De klant heeft niet de minimale leeftijd voor deze film.");
                    else
                    {
                        if (kaartje.RechtOpKorting)
                            totaal += kaartje.Prijs * (1 - kaartjeKorting);
                        else
                            totaal += kaartje.Prijs;
                    }
                }

                if (Klant.RechtOpKorting)
                    totaal = totaal * (1 - klantKorting);

                return totaal;
            }
        }

        public Reservering(Klant klant)
        {
            Klant = klant;
            Kaartjes = new List<Kaartje>();
        }
    }
}
