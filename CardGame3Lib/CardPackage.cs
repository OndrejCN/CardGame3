using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class CardPackage
    {
        List<Card> myCardList = new List<Card>();

        public CardPackage(List<Card> listOfCards)
        {
            myCardList = listOfCards;
        }
        public List<Card> MyCardList
        {
            get { return myCardList; }
        }
    }
}
