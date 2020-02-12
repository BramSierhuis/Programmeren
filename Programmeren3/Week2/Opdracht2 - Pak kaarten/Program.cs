using System;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        void Start()
        {
            DeckOfCards deck = new DeckOfCards();
            deck.Print();

            deck.Shuffle();
            deck.Print();
        }
    }
}
