using System.Collections.Generic;

namespace GoFish.Models
{
  public class Game
  {
    private static List<Card> _deck = Card.DeckBuilder();
    public List<Card> Deck { get; }
    public int PlayerOneScore { get; set; }
    public int PlayerTwoScore { get; set; }
    
    public Game()
    {
      Deck = _deck;
      PlayerOneScore = 0;
      PlayerTwoScore = 0;
    }
  }
}