using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;

namespace GoFish.Tests
{
  [TestClass]
  public class CardTests : IDisposable
  {
    public void Dispose()
    {
      Card.ClearAll();
    }

    [TestMethod]
    public void CardConstructor_CreateInstanceOfCard_Card()
    {
      Card newCard = new Card("hearts", "king");
      Assert.AreEqual(typeof(Card), newCard.GetType());
    }

    [TestMethod]
    public void DeckBuilder_CreateADeck_List()
    {
      List<Card> newDeck = Card.DeckBuilder();
      Assert.AreEqual(52, newDeck.Count);
    }

  }
}