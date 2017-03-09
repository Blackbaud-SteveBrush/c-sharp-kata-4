using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Kata3
{
  public class Leaderboard
  {
    private List<Player> _players;

    public void AddPlayers(string jsonData) 
    {
      _players = JsonConvert.DeserializeObject<List<Player>>(jsonData);
    }

    private List<Player> SortPlayers(List<Player> players) 
    {
      return players.OrderByDescending(p => p.Level).ToList();
    }

    public void PrintStats()
    {
      var sortedPlayers = SortPlayers(_players);
      var winner = sortedPlayers.First();
      var loser = sortedPlayers.Last();

      Console.WriteLine("Leaderboard:");
      foreach (var player in sortedPlayers) 
      {
        Console.WriteLine(player.GetDetails());
      }
      
      Console.WriteLine($"Congrats to {winner.FullName} for the win!");
      Console.WriteLine($"{loser.FullName}, you're a real American loser... :(");
    }
  }
}
