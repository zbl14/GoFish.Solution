using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;

namespace GoFish.Tests
{
  [TestClass]
  public class GameTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void GameConstructor_CreateInstanceOfGame_List()
    {
      Game newGame = new Game();
      Assert.AreEqual(52, newGame.Deck.Count);
    }
  }
}