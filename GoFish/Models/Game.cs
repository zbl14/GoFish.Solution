using System;
using System.Collections.Generic;

namespace GoFish.Models
{
  public class Game
  {
    private static List<Card> _deck = Card.DeckBuilder();
    private static List<Card> _handOne = new List<Card> {}; 
        private static List<Card> _handTwo = new List<Card> {};
    public List<Card> Deck { get; }
    public int PlayerOneScore { get; set; }
    public int PlayerTwoScore { get; set; }
    
    public Game()
    {
      Deck = _deck;
      PlayerOneScore = 0;
      PlayerTwoScore = 0;
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
          int rndCard = rnd.Next(Deck.Count);
          _handOne.Add(Deck[rndCard]);
          Deck.RemoveAt(rndCard);
        }
      } 
      else
      {
        for (int i = 0; i < num; i++)
        {
          int rndCard = rnd.Next(Deck.Count);
          _handTwo.Add(Deck[rndCard]);
          Deck.RemoveAt(rndCard);
        }
      } 
    }

  }
}