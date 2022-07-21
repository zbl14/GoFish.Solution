using System;
using System.Collections.Generic;

namespace GoFish.Models
{
  public class Game
  {
    private static List<Card> _deck = new List<Card> {};
    private static List<Card> _handOne = new List<Card> {}; 
    private static List<Card> _handTwo = new List<Card> {};
    public int PlayerOneScore { get; set; }
    public int PlayerTwoScore { get; set; }
    
    public Game()
    {
      _deck = Card.DeckBuilder();
      PlayerOneScore = 0;
      PlayerTwoScore = 0;
    }

    public List<Card> GetDeck()
    {
      return _deck;
    }

    public List<Card> GetHandOne()
    {
      return _handOne;
    }

    public List<Card> GetHandTwo()
    {
      return _handTwo;
    }

    public void Draw(int num, string player)
    {
      Random rnd = new Random();
      if (player == "player1")
      {
        for (int i = 0; i < num; i++)
        {
          int rndCard = rnd.Next(_deck.Count);
          _handOne.Add(_deck[rndCard]);
          _deck.RemoveAt(rndCard);
        }
      } 
      else if (player == "player2")
      {
        for (int i = 0; i < num; i++)
        {
          int rndCard = rnd.Next(_deck.Count);
          _handTwo.Add(_deck[rndCard]);
          _deck.RemoveAt(rndCard);
        }
      } 
    }

    public static void ClearAll()
    {
      _deck.Clear();
      _handOne.Clear();
      _handTwo.Clear();
    }
  }
}