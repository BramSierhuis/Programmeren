using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class CompetitionMatch : FootballMatch
    {
        private int roundNumber;

        public CompetitionMatch(FootballTeam homeTeam, FootballTeam awayteam, int roundNumber) : base(homeTeam, awayteam)
        {
            this.roundNumber = roundNumber;
        }
    }
}
