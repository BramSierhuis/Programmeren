using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3___Oorlogje
{
    public class WarCardGame : CardGame
    {
        Player p1, p2;

        public WarCardGame(Player p1, Player p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public void StartNewGame()
        {
            deck.Shuffle();

            for(int i = 0; i < deck.allPlayingCards.Count; i++)
            {
                if (i % 2 == 0)
                    p1.AddCard(deck.allPlayingCards[i]);
                else
                    p2.AddCard(deck.allPlayingCards[i]);
            }
        }

        public void NextCard()
        {
            PlayingCard p1card = p1.GetNextCard();
            PlayingCard p2card = p2.GetNextCard();

            Console.WriteLine("[{0}; {1}] " + p1card.ToString() + " - [{2}; {3}] " + p2card.ToString(), p1.name, p1.cards.Count, p2.name, p2.cards.Count);

            if(p1card.rank == p2card.rank)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("2 cards lost...");
                Console.WriteLine("Cards left: [{0}] " + p1.cards.Count + "x, [{1}] " + p2.cards.Count + "x", p1.name, p2.name);
            } 
            else if(p1card.rank > p2card.rank)
            {
                p1.AddCard(p1card);
                p1.AddCard(p2card);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(p1.name + " got the cards");
            }
            else if(p1card.rank < p2card.rank)
            {
                p2.AddCard(p2card);
                p2.AddCard(p1card);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(p2.name + " got the cards");
            }

            Console.ResetColor();
        }

        public bool EndOfGame()
        {
            if (p1.cards.Count == 0 || p2.cards.Count == 0)         
                return true;

            return false;
        }

        public Player GetWinner()
        {
            if (p1.cards.Count == 0)
                return p2;
            else
                return p1;
        }
    }
}
