using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardDeck
{
    public class DeckOfCards
    {
        List<PlayingCard> allPlayingCards = new List<PlayingCard>();

        public DeckOfCards()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    allPlayingCards.Add(new PlayingCard(j, (CardSuit)i));
                }
            }
        }

        public void Print()
        {
            foreach(PlayingCard card in allPlayingCards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void Shuffle()
        {
            //Not the most efficient, but it is a nice 1 liner
            Random rnd = new Random();
            allPlayingCards = allPlayingCards.OrderBy(x => rnd.Next()).ToList();
        }
    }
}
