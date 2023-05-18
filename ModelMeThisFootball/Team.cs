using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThisFootball
{
    public class Team
    {
        public Coach Coach { get; set; }
        private List<FootballPlayer> players;

        public List<FootballPlayer> Players
        {
            get { return players; }
            set
            {
                if (value.Count >= 11 && value.Count <= 22)
                {
                    players = value;
                }
                else
                    throw new ArgumentException("The team should have between 11 and 22 players.");
            }
        }

        public double PlayersAverageAge
        {
            get
            {
                if (Players.Count == 0)
                {
                    return 0;
                }

                int totalAge = 0;
                foreach (FootballPlayer player in Players)
                {
                    totalAge += player.Age;
                }

                return (double)totalAge / Players.Count;
            }
        }
    }
}
