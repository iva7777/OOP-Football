using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMeThisFootball
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Referee AssistantReferee1 { get; set; }
        public Referee AssistantReferee2 { get; set; }
        public List<Tuple<int, string>> Goals { get; set; }
        public string GameResult { get; set; }
        public Team Winner { get; set; }

        public Game()
        {
            Team1 = new Team();
            Team2 = new Team();
            Goals = new List<Tuple<int, string>>();
        }

        public void AddGoal(int minute, string player)
        {
            Goals.Add(new Tuple<int, string>(minute, player));
        }

        public void EndGame()
        {

        }

    }
}
