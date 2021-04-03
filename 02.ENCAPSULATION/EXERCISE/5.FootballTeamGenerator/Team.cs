using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string nameTeam;
        private Dictionary<string, Player> playerByName;

        public string Name
        {
            get => nameTeam;
            set
            {
                Validator.Throw_If_String_Is_Null_OR_Empty(value, "A name should not be empty.");
                nameTeam = value;
            }
        }
        public Team(string name)
        {
            this.Name = name;
            playerByName = new Dictionary<string, Player>();
        }
        public void AddPlayer(Player player)
        {
            this.playerByName.Add(player.Name, player);
        }
        public void RemovePlayer(string player)
        {
            if (!playerByName.ContainsKey(player))
            {
                throw new ArgumentException($"Player {player} is not in {this.Name} team.");
            }
            playerByName.Remove(player);
        }
        public double AverageRatink()
        {
            if (this.playerByName.Count == 0)
            {
                return 0;
            }
            return Math.Round(this.playerByName.Values.Average(p => p.AverageSkilsPoint));
        }

    }
}
