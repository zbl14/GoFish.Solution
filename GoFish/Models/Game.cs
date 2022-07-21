using System.Collections.Generic;

namespace GoFish.Models
{
  public class Game
  {
    private static List<Card> _deck = Card.DeckBuilder();
    private static List<Card> _hand = new List<Card> {}; 
    public List<Card> Deck { get; }
    public int PlayerOneScore { get; set; }
    public int PlayerTwoScore { get; set; }
    
    public Game()
    {
      Deck = _deck;
      PlayerOneScore = 0;
      PlayerTwoScore = 0;
    }

    public List<Card> GetHand()
    {
      return _hand;
    }

    public void Draw(int num, string player)
    {
      
    }

  }
}