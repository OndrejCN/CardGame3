using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class Card
    {
        public int number;
        public Card(int n)
        {
            number = n;
        }
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            // If parameter cannot be cast to ThreeDPoint return false:
            Card c = obj as Card;

            if ((object)c == null)
            {
                return false;
            }

            // Return true if the fields match:
            return number == c.number;
        }

        public bool Equals(Card c)
        {
            if ((object)c == null)
            {
                return false;
            } 
            // Return true if the fields match:
            return number == c.number;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ number;
        }
    }
}