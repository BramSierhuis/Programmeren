using System;
using System.Linq;

namespace Opdracht3___Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

            Console.ReadLine();
        }

        void Start()
        {
            YahtzeeGame yahtzeeGame = new YahtzeeGame();

            SpeelYahtzee(yahtzeeGame); // speel het spel
        }

        void SpeelYahtzee(YahtzeeGame game)
        {
            int aantalPogingen = 0;

            do
            {
                game.Gooi(); // gooi dobbelstenen
                game.ToonWorp(); // toon worp
                aantalPogingen++;
            } 
            while (!game.Yahtzee());

            Console.WriteLine("Aantal pogingen nodig voor yahtzee: {0}", aantalPogingen);
        }
    }
}
