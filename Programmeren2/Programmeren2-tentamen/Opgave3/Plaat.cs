using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave3
{
    public class Plaat
    {
        public int ranking;
        public string titel;
        public string artiest;
        public int jaar;

        public Plaat(int ranking, string titel, string artiest, int jaar)
        {
            this.ranking = ranking;
            this.titel = titel;
            this.artiest = artiest;
            this.jaar = jaar;
        }
    }
}
