using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2
{
    public class iDEALBetaling : IBetaalWijze
    {
        public void Betaal(float bedrag)
        {
            Console.WriteLine("Bedrag {0} is betaald met iDEAL", bedrag);
        }
    }
}
