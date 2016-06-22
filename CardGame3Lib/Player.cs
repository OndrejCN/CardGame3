using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class Player
    {
        Croupier myCroupier;
        public List<Card> CardsOnHand = new List<Card>();
        public Player(Croupier myC)
        {
            myCroupier = myC;
        }
        public void GetCard()
        {
            CardsOnHand.Add(myCroupier.GiveCard());
        }
    }
}
