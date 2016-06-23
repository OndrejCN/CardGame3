using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGame3Lib;
using Rhino.Mocks;
using System.Collections.Generic;

namespace UnitTestCardGame3Lib
{
    [TestClass]
    public class UnitTestCroupier
    {
        [TestMethod]
        public void TestInitGame()
        {
            var stubCardPackageProvider = MockRepository.GenerateStub<ICardPackageProvider>();
            List<Card> listOfCards = new List<Card>();
            listOfCards.Add(new Card(1));
            listOfCards.Add(new Card(2));
            listOfCards.Add(new Card(3));
            listOfCards.Add(new Card(3));
            stubCardPackageProvider.Stub(x => x.GetCardPackage()).Return(new CardPackage(listOfCards));

            Croupier testCroupier = new Croupier(stubCardPackageProvider);
            testCroupier.InitGame();
            CollectionAssert.AreEqual(listOfCards, testCroupier.myCards);
        }
        [TestMethod]
        public void TestGiveCard()
        {
            var stubCardPackageProvider = MockRepository.GenerateStub<ICardPackageProvider>();
            List<Card> listOfCards = new List<Card>();
            listOfCards.Add(new Card(5));
            stubCardPackageProvider.Stub(x => x.GetCardPackage()).Return(new CardPackage(listOfCards));

            Croupier testCroupier = new Croupier(stubCardPackageProvider);
            testCroupier.InitGame();    //mam vlozit do konstruktora krupiera?
            Assert.AreEqual(new Card(5), testCroupier.GiveCard());
        }
    }
}
