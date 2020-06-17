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
            
            Console.WriteLine("Opgave 6: ---------------");
            Opgave6();
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

        private void Opgave6()
        {
            List<FootballPlayer> team1players = new List<FootballPlayer>();
            List<FootballPlayer> team2players = new List<FootballPlayer>();
            List<FootballPlayer> team3players = new List<FootballPlayer>();
            List<FootballPlayer> team4players = new List<FootballPlayer>();

            List<FootballTeam> teams = new List<FootballTeam>();

            team1players.Add(new InternationalPlayer("Donny van der Beek", 23, 9));
            team1players.Add(new InternationalPlayer("Hakim Ziyech", 27, 32));

            team2players.Add(new FootballPlayer("Merle Maat", 18));
            team2players.Add(new FootballPlayer("Bram Sierhuis", 19));

            team3players.Add(new InternationalPlayer("Tymo Verpoort", 24, 2));
            team3players.Add(new InternationalPlayer("Jake Jackson", 21, 10));

            team4players.Add(new FootballPlayer("Jacq de Vries", 18));
            team4players.Add(new FootballPlayer("Anne de Groot", 19));

            FootballTeam team1 = new FootballTeam("Ajax", team1players);
            FootballTeam team2 = new FootballTeam("PSV", team2players);
            FootballTeam team3 = new FootballTeam("Feynoord", team3players);
            FootballTeam team4 = new FootballTeam("AZ", team4players);

            teams.Add(team1);
            teams.Add(team2);
            teams.Add(team3);
            teams.Add(team4);

            Competition competition = new Competition(teams);

            competition.Print();
        }
    }
}
