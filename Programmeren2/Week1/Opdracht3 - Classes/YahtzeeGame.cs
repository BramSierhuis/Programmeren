using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3___Classes
{
    class YahtzeeGame
    {
        Dobbelsteen[] dobbelstenen = new Dobbelsteen[5];

        public void Init()
        {
            for(int i = 0; i < dobbelstenen.Length; i++)
            {
                dobbelstenen[i] = new Dobbelsteen();
            }
        }

        public void Gooi()
        {
            for (int i = 0; i < dobbelstenen.Length; i++)
            {
                dobbelstenen[i].Gooi();
            }
        }

        public void ToonWorp()
        {
            for (int i = 0; i < dobbelstenen.Length; i++)
            {
                dobbelstenen[i].ToonWaarde();
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        public bool Yahtzee()
        {
            int waarde = dobbelstenen[0].waarde;

            foreach(Dobbelsteen dobbelsteen in dobbelstenen)
            {
                if (waarde != dobbelsteen.waarde)
                    return false;
            }

            return true;
        }
    }
}
