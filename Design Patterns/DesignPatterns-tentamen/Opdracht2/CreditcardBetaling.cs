using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{
    public class CreditcardBetaling : IBetaalWijze
    {
        public void Betaal(float bedrag)
        {
            Console.WriteLine("Bedrag {0} is betaald met creditcard", bedrag);
        }
    }
}
