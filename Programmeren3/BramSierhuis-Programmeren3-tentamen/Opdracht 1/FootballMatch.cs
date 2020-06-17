using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public abstract class FootballMatch
    {
        public FootballTeam homeTeam;
        public FootballTeam awayTeam;

        public FootballMatch(FootballTeam homeTeam, FootballTeam awayTeam)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
        }
    }
}
