using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public static class Mixer
    {
        static Random rand = new Random();

        public static void RandomMix(List<Card> cards)
        {
            Console.WriteLine("Random mixing cards.");

            for (int i = 0; i < cards.Count; i++)
            {
                int fromIndex = GetRandNumber(cards.Count - 1);
                int toIndex = GetRandNumber(cards.Count - 1);
                Card buffer = cards[toIndex];
                cards[toIndex] = cards[fromIndex];
                cards[fromIndex] = buffer;
            }
        }
        public static void ShuffleMix(List<Card> cards)
        {
            Console.WriteLine("Shuffle mixing cards.");
            for (int i = 0; i < cards.Count - 1; i += 2)
            {
                Card tempValue = cards[i];
                cards[i] = cards[i + 1];
                cards[i + 1] = tempValue;
            }
        }
        public static void CutMix(List<Card> cards)
        {
            Console.WriteLine("Cut mixing cards.");
            int amountOfCardsForFlipping = GetRandNumber(cards.Count);
            List<Card> cardsToFlip = TakeCardsForFlipping(cards, amountOfCardsForFlipping);
            ShiftArrayOfCards(cards, amountOfCardsForFlipping);
            AddCardsToFlipToBottomOfCards(cardsToFlip, cards);
        }

        public static int GetRandNumber(int maxInterval)
        {            
            return rand.Next(1, maxInterval);
        }
        public static List<Card> TakeCardsForFlipping(List<Card> cards, int amount)
        {
            List<Card> cardBuffer = new List<Card>();
            for (int j = 0; j < amount; j++)    //take cards for flipping
            {
                cardBuffer.Add(cards[j]);
            }
            return cardBuffer;
        }
        public static void ShiftArrayOfCards(List<Card> cards, int amount)
        {
            cards.RemoveRange(0, amount);
        }
        public static void AddCardsToFlipToBottomOfCards(List<Card> cardsToFlip, List<Card> cards)
        {
            cards.AddRange(cardsToFlip);
        }
    }
}
