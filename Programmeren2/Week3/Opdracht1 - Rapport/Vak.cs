using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht1___Rapport
{
    public class Vak
    {
        public string naam;
        public int cijfer;
        public PraktijkBeoordeling praktijkBeoordeling;

        public Vak(string naam, int cijfer, PraktijkBeoordeling praktijkBeoordeling)
        {
            this.naam = naam;
            this.cijfer = cijfer;
            this.praktijkBeoordeling = praktijkBeoordeling;
        }
    }
}
