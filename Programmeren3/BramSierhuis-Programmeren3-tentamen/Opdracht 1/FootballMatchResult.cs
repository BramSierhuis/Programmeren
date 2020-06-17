using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class FootballMatchResult
    {
        public int HomeTeamGoals { get; }
        public int AwayTeamGoals { get; }
        public int HomeTeamPoints { 
            get
            {
                return GetPoints(TeamType.HomeTeam);
            } 
        }        
        public int AwayTeamPoints { 
            get
            {
                return GetPoints(TeamType.AwayTeam);
            } 
        }

        public FootballMatchResult(int homeTeamGoals, int awayTeamGoals)
        {
            HomeTeamGoals = homeTeamGoals;
            AwayTeamGoals = awayTeamGoals;
        }

        public void Print()
        {
            Console.WriteLine("Football match result: {0} - {1}", HomeTeamGoals, AwayTeamGoals);
            Console.WriteLine("Home points: " + HomeTeamPoints);
            Console.WriteLine("Away points: " + AwayTeamPoints);
        }

        private int GetPoints(TeamType teamType)
        {
            if (HomeTeamGoals == AwayTeamGoals)
                return 1;
            else
            {
                if(HomeTeamGoals > AwayTeamGoals)
                {
                    if (teamType == TeamType.HomeTeam)
                        return 3;
                }
                else
                {
                    if (teamType == TeamType.AwayTeam)
                        return 3;
                }
            }

            return 0;
        }
    }
}
