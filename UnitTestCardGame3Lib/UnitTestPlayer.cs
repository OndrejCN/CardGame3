using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardGame3Lib;
using Rhino.Mocks;

namespace UnitTestCardGame3Lib
{
    [TestClass]
    public class UnitTestPlayer
    {
        //[TestMethod]
        //public void TestGetCard()
        //{
        //    var stubCroupier = MockRepository.GenerateStub<ICroupier>();
        //    stubCroupier.Stub(x => x.GiveCard()).Return(new Card(5));
        //    Player player = new Player(stubCroupier);
        //    player.GetCard();
        //    Assert.AreEqual(new Card(5), player.cardsOnHand[0]);
        //}
        //[TestMethod]
        //public void TestGiveCard()
        //{
        //    var stubCroupier = MockRepository.GenerateStub<ICroupier>();
        //    Player player = new Player(stubCroupier)
        //        { cardsOnHand = { new Card(1), new Card(2), new Card(3) } };
        //    Assert.AreEqual(new Card(2), player.GiveCard(1));
        //}
    }
}
