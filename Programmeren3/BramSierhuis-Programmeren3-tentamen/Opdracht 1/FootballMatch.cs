using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public abstract class FootballMatch
    {
        private FootballTeam homeTeam;
        private FootballTeam awayTeam;

        public FootballMatch(FootballTeam homeTeam, FootballTeam awayTeam)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
        }
    }
}
