using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class CardPackage
    {
        public List<Card> myCardList = new List<Card>();

        public CardPackage()
        {
            for (int i = 1; i <= 32; i++)
            {
                myCardList.Add(new Card(i));       
            }
        }
    }
}
