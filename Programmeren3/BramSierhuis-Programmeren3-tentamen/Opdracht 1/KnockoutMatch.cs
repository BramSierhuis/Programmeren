using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3opgaven
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
