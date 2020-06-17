using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren3opgaven
{
    public class FootballTeam
    {
        private string name;

        public List<FootballPlayer> TeamMembers { get; }
        public string Name { get { return name; } }
        public int TotalPoints { get; set; }
        public int TotalTransferValue
        {
            get
            {
                int value = 0;

                foreach(FootballPlayer player in TeamMembers)
                {
                    value += player.CalculateTransferValue();
                }

                return value;
            }
        }

        public FootballTeam(string name, List<FootballPlayer> teamMembers)
        {
            this.name = name;
            TeamMembers = teamMembers;
            TotalPoints = 0;
        }
    }
}
