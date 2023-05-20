using System;
using System.Linq;
namespace ModelMeThisFootball
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer[] galaxyGliders =
            {
                new Goalkeeper("Ethan Smith", 10, 28, 188),
                new Striker("Nick Johnson", 7, 25, 173),
                new Striker("Benjamin Rodriguez", 4, 23, 183),
                new Defender("Liam Wilson", 2, 24, 168),
                new Defender("Jack Martinez", 11, 18, 178),
                new Defender("Noah Harris", 9, 19, 185),
                new Defender("Henry Davis", 17, 21, 174),
                new Midfield("Jacob Davis", 5, 17, 175),
                new Midfield("Jonas Garcia", 8, 23, 183),
                new Midfield("Daniel Clark", 1, 19, 190),
                new Midfield("Mario Fuentes", 4, 26, 187)
            };

            FootballPlayer[] wildCats =
            {
                new Goalkeeper("Lucas Martinez", 10, 27, 172),
                new Striker("Ian Thompson", 7, 25, 168),
                new Striker("Sebastian Rodriguez", 4, 18, 188),
                new Defender("Rob Willis", 2, 24, 170),
                new Defender("Martin Doe", 6, 19, 160),
                new Defender("Naithan Harris", 11, 23, 185),
                new Defender("Henry Mavis", 9, 21, 163),
                new Midfield("Jacob Harris", 3, 17, 175),
                new Midfield("Mark Russo", 8, 24, 180),
                new Midfield("Ethan Clock", 5, 21, 175),
                new Midfield("Jean Martinez", 1, 20, 190)
            };

            Coach[] coaches =
            {
                new Coach("Antonio Marquez", 43),
                new Coach("Jorge Perez", 50)
            };

            Team team1 = new Team("Galaxy Gliders", coaches[0], galaxyGliders.ToList());
            Team team2 = new Team("Wild Cats", coaches[1], wildCats.ToList());

            Referee referee = new Referee("Emily Johnson", 32);
            Referee assistantReferee1 = new Referee("Elton Davis", 35);
            Referee assistantReferee2 = new Referee("David Effes", 42);

            Game game = new Game(team1, team2, referee, assistantReferee1, assistantReferee2);

            game.AddGoal(17, galaxyGliders[1]);
            game.AddGoal(35, wildCats[5]);
            game.AddGoal(42, galaxyGliders[6]);
            game.AddGoal(56, wildCats[10]);
            game.AddGoal(87, galaxyGliders[5]);
            Console.WriteLine("------------------------");
            Console.WriteLine(game.GameResult);
            Console.WriteLine("------------------------");
            Console.WriteLine($"The winner is: {game.Winner.Name}.");
        }
    }
}

