using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class InternationalPlayer : FootballPlayer
    {
        private int gamesPlayed;

        public InternationalPlayer(string name, int age, int gamesPlayed) : base (name, age)
        {
            this.gamesPlayed = gamesPlayed;
        }

        public override int CalculateTransferValue()
        {
            return base.CalculateTransferValue() + (int)(gamesPlayed * 0.5);
        }

        public override string ToString()
        {
            return base.ToString() + " (" + gamesPlayed + " int. games)";
        }
    }
}
