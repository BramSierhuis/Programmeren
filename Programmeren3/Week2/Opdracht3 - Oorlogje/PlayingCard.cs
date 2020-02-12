using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3___Oorlogje
{
    public class PlayingCard
    {
        public int rank;
        CardSuit suit;

        public PlayingCard(int rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            string rankText;

            switch (rank)
            {
                case 11:
                    rankText = "Jack";
                    break;
                case 12:
                    rankText = "Queen";
                    break;
                case 13:
                    rankText = "King";
                    break;
                case 14:
                    rankText = "Ace";
                    break;
                default:
                    rankText = rank.ToString();
                    break;
            }

            return rankText + " of " + suit.ToString();
        }
    }
}
