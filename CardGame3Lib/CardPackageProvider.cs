using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class CardPackageProvider : ICardPackageProvider
    {       
        public CardPackage GetCardPackage(TypeOfGame tog)
        {
            return tog.CreateCardPackage();            
        }       
        //public static List<Card> CreateDefaultCards()
        //{
        //    List<Card> listOfCards = new List<Card>();
        //    for (int i = 1; i <= 32; i++)
        //    {
        //        listOfCards.Add(new Card(i));
        //    }
        //    return listOfCards;
        //}
    }
}
