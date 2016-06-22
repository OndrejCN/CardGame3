using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame3Lib;

namespace CardGame3Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Croupier myCroupier = new Croupier(new CardPackageProvider());
            Player player1 = new Player(myCroupier);
            myCroupier.InitGame();
            
            player1.GetCard();
            player1.GetCard();
            player1.GiveCard(1);
            player1.GetCard();
            player1.GetCard();

            Console.WriteLine("Cards on hand: ");
            foreach (Card i in player1.CardsOnHand)
            {
                Console.Write(i.number + ", ");
            }
            Console.WriteLine("\nCards in Cropiers CardList: ");
            foreach (Card card in myCroupier.myCards)
            {
                Console.Write(card.number + ", ");
            }
            Console.ReadKey();
        }
    }
}
