using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;

namespace GoFish.Tests
{
  [TestClass]
  public class GameTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Game.ClearAll();
    // }

    [TestMethod]
    public void GameConstructor_CreateInstanceOfGame_List()
    {
      Game newGame = new Game();
      Assert.AreEqual(52, newGame.Deck.Count);
    }

    [TestMethod]
    public void Draw_CreatListOfNCards_List()
    {
      int num = 5;
      string player = "player1";
      Game newGame = new Game();
      newGame.Draw(num, player);
      Assert.AreEqual(num, newGame.GetHandOne().Count);
      Assert.AreEqual(47, newGame.Deck.Count);
    }
  }
}