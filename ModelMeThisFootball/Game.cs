using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThisFootball
{
    public class Game
    {
        private Team team1;
        private Team team2;

        public Team Team1 { 
            get { return team1; }
            set
            {
                if (value.Players.Count == 11)
                {
                    team1 = value;
                }
                else
                {
                    throw new ArgumentException("Team 1 must have exactly 11 players!");
                }
            }
        }

        public Team Team2
        {
            get { return team2; }
            set
            {
                if (value.Players.Count == 11)
                {
                    team1 = value;
                }
                else
                {
                    throw new ArgumentException("Team 2 must have exactly 11 players!");
                }
            }
        }

        public Referee Referee { get; set; }
        public Referee AssistantReferee1 { get; set; }
        public Referee AssistantReferee2 { get; set; }
        public List<Tuple<int, FootballPlayer>> Goals { get; set; }
        public string GameResult { 
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"Game result:");

                stringBuilder.AppendLine($"Team {Team1}: {GetGoals(Team1)}");
                stringBuilder.AppendLine($"Team {Team2}: {GetGoals(Team2)}");

                return stringBuilder.ToString();
            }
        }
        public Team Winner { 
            get
            {
                int team1Goals = GetGoals(Team1);
                int team2Goals = GetGoals(Team2);

                if (team1Goals > team2Goals)
                {
                    return Team1;
                }
                else if (team2Goals > team1Goals)
                {
                    return Team2;
                }
                else
                {
                    return null; //score draw
                }
            }
        }

        public Game()
        {
            Team1 = new Team();
            Team2 = new Team();
            Goals = new List<Tuple<int, FootballPlayer>>();
        }

        public void AddGoal(int minute, FootballPlayer player)
        {
            TeamShoots(player);
            Goals.Add(new Tuple<int, FootballPlayer>(minute, player));
        }

        private void TeamShoots(FootballPlayer player)
        {
            if (Team1.Players.Contains(player))
            {
                Console.WriteLine($"Goal shooted by {player.Name} from Team 1");
            }
            else if (Team2.Players.Contains(player))
            {
                Console.WriteLine($"Goal shooted by {player.Name} from Team 2");
            }
        }

        private int GetGoals(Team team)
        {
            int goals = 0;
            foreach (var goal in Goals)
            {
                if (team.Players.Contains(goal.Item2))
                {
                    goals++;
                }
            }
            return goals;
        }

    }
}
