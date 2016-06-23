using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class Player : IPlayer
    {
        ICroupier myCroupier;
        public List<Card> cardsOnHand = new List<Card>();

        public Player(ICroupier myC)
        {
            myCroupier = myC;
        }
        public void GetCard()
        {
            cardsOnHand.Add(myCroupier.GiveCard());
        }
        public Card GiveCard(int position)
        {
            Card output = cardsOnHand[position];
            cardsOnHand.RemoveAt(position);
            return output;
        }
    }
}
