using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3opgaven
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
