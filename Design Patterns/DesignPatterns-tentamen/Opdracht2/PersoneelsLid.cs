using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{
    public abstract class PersoneelsLid
    {
        string naam;
        public IBetaalWijze BetaalWijze { get; set; }

        public PersoneelsLid(string naam)
        {
            this.naam = naam;
        }

        public void Betaal(float bedrag)
        {
            BetaalWijze.Betaal(bedrag);
        }
    }
}
