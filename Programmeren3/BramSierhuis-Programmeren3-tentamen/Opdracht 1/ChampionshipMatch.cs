﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public abstract class ChampionshipMatch : FootballMatch
    {
        public ChampionshipMatch(FootballTeam homeTeam, FootballTeam awayTeam) : base(homeTeam, awayTeam) { }
    }
}
