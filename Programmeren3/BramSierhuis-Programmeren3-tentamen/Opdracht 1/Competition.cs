using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class Competition
    {
        private List<FootballTeam> teams = new List<FootballTeam>();
        private List<FootballMatch> matches = new List<FootballMatch>();
        private Dictionary<FootballMatch, FootballMatchResult> results = new Dictionary<FootballMatch, FootballMatchResult>();

        private Random random = new Random();

        public Competition(List<FootballTeam> teams)
        {
            this.teams = teams;

            GenerateMatches();
            CalculateTeamPoints();
        }

        public void CalculateTeamPoints()
        {
            foreach(FootballMatch match in matches)
            {
                teams.Find(x => x == match.homeTeam).TotalPoints += results[match].HomeTeamPoints;
                teams.Find(x => x == match.awayTeam).TotalPoints += results[match].AwayTeamPoints;
            }
        }

        public void Print()
        {
            foreach(FootballTeam team in teams)
            {
                Console.WriteLine("{0} heeft {1} punten", team.Name, team.TotalPoints);
            }
        }

        private void GenerateMatches()
        {
            int counter = 0;

            foreach(FootballTeam team1 in teams)
            {
                foreach(FootballTeam team2 in teams)
                {
                    if (team1 != team2)
                    {
                        counter++;
                        CompetitionMatch homeMatch = new CompetitionMatch(team1, team2, counter);
                        matches.Add(homeMatch);

                        counter++;
                        CompetitionMatch awayMatch = new CompetitionMatch(team2, team1, counter);
                        matches.Add(awayMatch);

                        //Fill results
                        results.Add(homeMatch, new FootballMatchResult(random.Next(6), random.Next(6)));
                        results.Add(awayMatch, new FootballMatchResult(random.Next(6), random.Next(6)));
                    }            
                }
            }
        }
    }
}
