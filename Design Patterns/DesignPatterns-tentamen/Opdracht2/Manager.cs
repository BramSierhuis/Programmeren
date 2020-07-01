using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{
    public class Manager : PersoneelsLid
    {
        public Manager(string naam) : base(naam)
        {
            BetaalWijze = new CreditcardBetaling();
        }
    }
}
