using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class Croupier
    {
        CardPackageProvider myCpp;
        List<Card> myCards;
        public Croupier(CardPackageProvider cpp)
        {
            myCpp = cpp;
        }
        public void InitGame()
        {
            myCards = myCpp.GetCards();
        }
        public Card GiveCard()
        {
            Card output = myCards[0];
            myCards.RemoveAt(0);
            return output;
        }
    }
}
