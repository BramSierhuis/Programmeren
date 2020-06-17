using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht_1
{
    public class GroupStageMatch : ChampionshipMatch
    {
        private string groupName;

        public GroupStageMatch(FootballTeam homeTeam, FootballTeam awayTeam, string groupName) : base(homeTeam, awayTeam)
        {
            this.groupName = groupName;
        }
    }
}
