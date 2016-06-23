using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class CardPackageProvider : ICardPackageProvider
    {       
        CardPackage CreateCardPackage()
        {
            List<Card> listOfCards = new List<Card>();
            for (int i = 1; i <= 32; i++)
            {
                listOfCards.Add(new Card(i));
            }
            return new CardPackage(listOfCards);
        }
        public CardPackage GetCardPackage()
        {
            return CreateCardPackage();            
        }
    }
}
