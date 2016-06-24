using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class Croupier : ICroupier
    {
        ICardPackageProvider myCpp;
        public List<Card> myCards = new List<Card>();
        public Croupier(ICardPackageProvider cpp)
        {
            myCpp = cpp;
        }
        public void InitGame(TypeOfGame tog)
        {
            CardPackage cardPackage = myCpp.GetCardPackage(tog);
            foreach (Card card in cardPackage.MyCardList)
            {
                myCards.Add(card);
            }
        }
        public Card GiveCard()
        {
            Card output = myCards[0];
            myCards.RemoveAt(0);
            return output;
        }

        public void MixCards()
        {
            Mixer.RandomMix(myCards);
            Mixer.ShuffleMix(myCards);
            Mixer.CutMix(myCards);
        }
    }
}
