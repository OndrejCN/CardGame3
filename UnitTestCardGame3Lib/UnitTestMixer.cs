using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGame3Lib;
using Rhino.Mocks;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestCardGame3Lib
{
    [TestClass]
    public class UnitTestMixer
    {
        [TestMethod]
        public void TestRandomMix()
        {            
            List<Card> originalCards = new List<Card>()
                { new Card(1), new Card(2), new Card(3), new Card(4), new Card(5)};

            //List<Card> mixedCards = new List<Card>(originalCards.Count);

            //originalCards.ForEach((item) =>
            //{
            //    mixedCards.Add(item);
            //});
            List<Card> mixedCards = new List<Card>(originalCards);

            Mixer.RandomMix(mixedCards);
            CollectionAssert.AreNotEqual(originalCards, mixedCards);
        }
        [TestMethod]
        public void TestShuffleMix()
        {
            List<Card> originalCards = new List<Card>()
                { new Card(1), new Card(2), new Card(3), new Card(4), new Card(5)};
            List<Card> mixedCards = new List<Card>(originalCards);
            Mixer.ShuffleMix(mixedCards);

            for (int i = 0; i < originalCards.Count-1; i += 2)
            {
                Assert.AreEqual(originalCards[i], mixedCards[i + 1]);
            }
        }
        [TestMethod]
        public void TestCutMix()
        {
            List<Card> originalCards = new List<Card>()
                { new Card(1), new Card(2), new Card(3), new Card(4), new Card(5)};
            List<Card> mixedCards = new List<Card>(originalCards);
            Mixer.CutMix(mixedCards);

            Assert.AreNotEqual(originalCards[0], mixedCards[0]);
        }
        [TestMethod]
        public void TestGetRandNumber()
        {
            int range = 100;
            int x = Mixer.GetRandNumber(range);
            Assert.AreEqual(true, Enumerable.Range(1,range).Contains(x));
        }

        [TestMethod]
        public void TestTakeCardsForFlipping()
        {
            List<Card> originalCards = new List<Card>()
                { new Card(1), new Card(2), new Card(3), new Card(4), new Card(5)};
            List<Card> cardsForFlipping = Mixer.TakeCardsForFlipping(originalCards, 2);
            CollectionAssert.AreEqual(originalCards.GetRange(0, 2), cardsForFlipping);
        }
        [TestMethod]
        public void TestShiftArrayOfCards()
        {
            List<Card> originalCards = new List<Card>()
                { new Card(1), new Card(2), new Card(3), new Card(4), new Card(5)};
            List<Card> cardsForShifting = new List<Card>(originalCards);

            Mixer.ShiftArrayOfCards(cardsForShifting, 2);
            CollectionAssert.AreEqual(originalCards.GetRange(2, originalCards.Count-2), cardsForShifting);
        }
        [TestMethod]
        public void TestAddCardsToFlipToBottomOfCards()
        {
            List<Card> fullCards = new List<Card>()
                { new Card(1), new Card(2), new Card(3), new Card(4), new Card(5)};
            List<Card> cardsUncomplete = fullCards.GetRange(0, 2);
            List<Card> cardsForFlipping = fullCards.GetRange(2, 3);

            Mixer.AddCardsToFlipToBottomOfCards(cardsForFlipping, cardsUncomplete);

            CollectionAssert.AreEqual(fullCards, cardsUncomplete);
        }
    }
}