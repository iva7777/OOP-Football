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
                    team2 = value;
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

                stringBuilder.AppendLine($"Team {Team1.Name}: {GetGoals(Team1)}");
                stringBuilder.AppendLine($"Team {Team2.Name}: {GetGoals(Team2)}");

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

        public Game(Team team1, Team team2, Referee referee, Referee assistant1, Referee assistant2)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assistant1;
            AssistantReferee2 = assistant2;
            Goals = new List<Tuple<int, FootballPlayer>>();
        }

        public void AddGoal(int minute, FootballPlayer player)
        {
            TeamShoots(player, minute);
            Goals.Add(new Tuple<int, FootballPlayer>(minute, player));
        }

        private void TeamShoots(FootballPlayer player, int minute)
        {
            if (Team1.Players.Contains(player))
            {
                Console.WriteLine($"Goal shooted by {player.Name} from {Team1.Name} at {minute} minute.");
            }
            else if (Team2.Players.Contains(player))
            {
                Console.WriteLine($"Goal shooted by {player.Name} from {Team2.Name} at {minute} minute.");
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
