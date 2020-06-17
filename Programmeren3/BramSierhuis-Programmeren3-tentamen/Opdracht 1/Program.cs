using System;
using System.Collections.Generic;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();

            Console.ReadKey();
        }

        private void Start()
        {
            Console.WriteLine("Opgave 1: ---------------");
            Opgave1();
            Console.WriteLine();

            Console.WriteLine("Opgave 2: ---------------");
            Opgave2();
            Console.WriteLine();

            Console.WriteLine("Opgave 3: ---------------");
            Opgave3();
            Console.WriteLine();
            
            Console.WriteLine("Opgave 5: ---------------");
            Opgave5();
            Console.WriteLine();
        }

        private void Opgave1()
        {
            FootballPlayer player = new FootballPlayer("Peter de Groot", 25);

            Console.WriteLine(player.ToString());
        }

        private void Opgave2()
        {
            List<FootballPlayer> players = new List<FootballPlayer>();

            InternationalPlayer player1 = new InternationalPlayer("Donny van der Beek", 23, 9);
            InternationalPlayer player2 = new InternationalPlayer("Hakim Ziyech", 27, 32);

            FootballPlayer player3 = new FootballPlayer("Merle Maat", 18);
            FootballPlayer player4 = new FootballPlayer("Bram Sierhuis", 19);

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);

            foreach(FootballPlayer player in players)
            {
                Console.WriteLine(player.ToString());
            }
        }

        private void Opgave3()
        {
            //Dit is natuurlijk herhalende code, maar gezien de opdrachten los van elkaar staan maak ik dit ook los
            List<FootballPlayer> players = new List<FootballPlayer>();

            InternationalPlayer player1 = new InternationalPlayer("Donny van der Beek", 23, 9);
            InternationalPlayer player2 = new InternationalPlayer("Hakim Ziyech", 27, 32);

            FootballPlayer player3 = new FootballPlayer("Merle Maat", 18);
            FootballPlayer player4 = new FootballPlayer("Bram Sierhuis", 19);

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);

            FootballTeam team = new FootballTeam("Ajax", players);

            Console.WriteLine("Total transfervalue: " + team.TotalTransferValue + "m");
        }

        private void Opgave5()
        {
            FootballMatchResult result1 = new FootballMatchResult(2, 1);
            FootballMatchResult result2 = new FootballMatchResult(3, 3);
            FootballMatchResult result3 = new FootballMatchResult(1, 5);

            result1.Print();
            Console.WriteLine();

            result2.Print();
            Console.WriteLine();

            result3.Print();
        }
    }
}
