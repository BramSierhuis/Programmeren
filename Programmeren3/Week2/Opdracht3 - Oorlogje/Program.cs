using System;

namespace Opdracht3___Oorlogje
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
            Player player1 = new Player("John");
            Player player2 = new Player("Emma");

            WarCardGame war = new WarCardGame(player1, player2);
            PlayTheGame(war);
        }
        void PlayTheGame(WarCardGame war)
        {
            war.StartNewGame();
            while (!war.EndOfGame())
            {
                war.NextCard();
            }

            Console.WriteLine();
            Console.WriteLine(war.GetWinner().name + " has won!");
        }
    }
}
