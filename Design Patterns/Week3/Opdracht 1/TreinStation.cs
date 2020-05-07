using System;
using System.Collections.Generic;
using System.Text;

namespace Opracht_1
{
    public class TreinStation
    {
        public string Naam { get; set; }
        public string AankomstSpoor { get; set; }
        public DateTime AankomstTijd { get; set; }
        public DateTime VertrekTijd { get; set; }

        public TreinStation(string naam, string aankomstSpoor, DateTime aankomstTijd, DateTime vertrekTijd)
        {
            Naam = naam;
            AankomstSpoor = aankomstSpoor;
            AankomstTijd = aankomstTijd;
            VertrekTijd = vertrekTijd;
        }
    }
}
