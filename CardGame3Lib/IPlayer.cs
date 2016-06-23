using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    interface IPlayer
    {
        void GetCard();
        Card GiveCard(int position);
    }
}
