using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3___Classes
{
    class Dobbelsteen
    {
        public int waarde;
        Random rnd;

        public Dobbelsteen(Random rnd)
        {
            this.rnd = rnd;
        }

        public void Gooi()
        {
            waarde = rnd.Next(1, 7);
        }

        public void ToonWaarde()
        {
            Console.Write(waarde);
        }
    }
}
