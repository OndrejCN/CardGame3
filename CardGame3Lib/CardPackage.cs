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
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to ThreeDPoint return false:
            CardPackage cp = obj as CardPackage;

            if ((object)cp == null)
            {
                return false;
            }

            // Return true if the fields match:
            return MyCardList.SequenceEqual(cp.MyCardList);
        }

        public bool Equals(CardPackage cp)
        {
            if ((object)cp == null)
            {
                return false;
            }
            // Return true if the fields match:
            return MyCardList.SequenceEqual(cp.MyCardList);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
