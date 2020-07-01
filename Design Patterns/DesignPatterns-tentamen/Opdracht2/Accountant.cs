using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{
    public class Accountant : PersoneelsLid
    {
        public Accountant(string naam) : base(naam)
        {
            BetaalWijze = new iDEALBetaling();
        }
    }
}
