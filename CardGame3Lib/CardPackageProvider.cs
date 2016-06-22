using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class CardPackageProvider : ICardPackageProvider
    {
        public CardPackage myCardPackage;
        public void CreateCardPackage()
        {
            myCardPackage = new CardPackage();
        }
        public List<Card> GetCards()
        {
            CreateCardPackage();
            return myCardPackage.myCardList;
        }
    }
}
