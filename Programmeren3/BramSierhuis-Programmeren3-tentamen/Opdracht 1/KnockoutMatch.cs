using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class KnockoutMatch : ChampionshipMatch
    {
        private KnockoutType knockoutType;

        public KnockoutMatch(FootballTeam homeTeam, FootballTeam awayTeam, KnockoutType knockoutType) : base(homeTeam, awayTeam)
        {
            this.knockoutType = knockoutType;
        }
    }
}
