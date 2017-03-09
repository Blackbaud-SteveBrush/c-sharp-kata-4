using System.IO;

namespace Kata3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var jsonString = File.ReadAllText("player-data.json");
            var leaderboard = new Leaderboard();
            leaderboard.AddPlayers(jsonString);
            leaderboard.PrintStats();
        }
    }
}
