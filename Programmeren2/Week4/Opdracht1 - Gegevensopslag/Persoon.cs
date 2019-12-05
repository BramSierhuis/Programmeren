using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Gegevensopslag
{
    class Persoon
    {
        public string naam;
        public int leeftijd;
        public string woonplaats;

        public Persoon(string naam, int leeftijd, string woonplaats)
        {
            this.naam = naam;
            this.leeftijd = leeftijd;
            this.woonplaats = woonplaats;
        }
    }
}
