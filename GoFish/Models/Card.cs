using System.Collections.Generic;

namespace GoFish.Models
{
  public class Card
  {
    public string Suit { get; set; }
    public string Rank { get; set; }
    private static List<Card> _instances = new List<Card> {};
    
    private static string[] suits = { "hearts", "clubs", "spades", "diamonds" };
    private static string[] ranks = { "ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king" };

    public Card(string suit, string rank)
    {
      Suit = suit;
      Rank = rank;
    }
  }
}