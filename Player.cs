using System;

namespace Kata3
{
  public class Player : IComparable<Player>
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName 
    { 
      get { return $"{FirstName} {LastName}"; }
    }
    public int Level { get; set; }

    public Player(string firstName, string lastName, int level) 
    {
      FirstName = firstName;
      LastName = lastName;
      Level = level;
    }

    public int CompareTo(Player player) 
    {
      return player.Level.CompareTo(Level);
    }

    public string GetDetails() 
    {
      return $"{FirstName} {LastName} - Level {Level}";
    }
  }
}
