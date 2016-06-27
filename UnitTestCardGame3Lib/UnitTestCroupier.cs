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
            SedmaGame sedmaGame = new SedmaGame();
            List<Card> listOfCards = new List<Card>();
            listOfCards.Add(new Card(1));
            listOfCards.Add(new Card(2));
            listOfCards.Add(new Card(3));
            stubCardPackageProvider.Stub(x => x.GetCardPackage(sedmaGame)).Return(new CardPackage(listOfCards));

            Croupier testCroupier = new Croupier(stubCardPackageProvider);
            testCroupier.InitGame(sedmaGame);
            CollectionAssert.AreEqual(listOfCards, testCroupier.myCards);
        }
        [TestMethod]
        public void TestGiveCard()
        {
            var stubCardPackageProvider = MockRepository.GenerateStub<ICardPackageProvider>();
            SedmaGame sedmaGame = new SedmaGame();
            List<Card> listOfCards = new List<Card>();
            listOfCards.Add(new Card(5));
            stubCardPackageProvider.Stub(x => x.GetCardPackage(sedmaGame)).Return(new CardPackage(listOfCards));

            Croupier testCroupier = new Croupier(stubCardPackageProvider);
            testCroupier.InitGame(sedmaGame);
            Assert.AreEqual(new Card(5), testCroupier.GiveCard());
        }
        [TestMethod]
        public void TestMixCards()
        {
            var stubCardPackageProvider = MockRepository.GenerateStub<ICardPackageProvider>();
            Croupier testCroupier = new Croupier(stubCardPackageProvider) {
                myCards = new SedmaGame().CreateCardPackage().MyCardList};
            testCroupier.MixCards();
            CollectionAssert.AreNotEqual(new SedmaGame().CreateCardPackage().MyCardList, testCroupier.myCards);
        }
    }
}
