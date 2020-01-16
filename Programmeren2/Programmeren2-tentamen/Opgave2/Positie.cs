using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2
{
    public class Positie
    {
        public int rij;
        public int kolom;
        public int waarde;

        public Positie(int rij, int kolom, int waarde)
        {
            this.rij = rij;
            this.kolom = kolom;
            this.waarde = waarde;
        }
    }
}
