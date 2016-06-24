using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame3Lib
{
    public class SedmaGame : TypeOfGame
    {
        public CardPackage CreateCardPackage()
        {
            Dictionary<int, string> colours = new Dictionary<int, string>();
            Dictionary<int, string> cardValues = new Dictionary<int, string>();
            List<Card> listOfCards = new List<Card>();

            InitDictionaryValues(colours, cardValues);

            Console.WriteLine("Creating Sedmove karty.");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 7; j <= 10; j++)
                {
                    listOfCards.Add(new Card(colours[i], j.ToString(), "SedmaGame"));
                    //listOfCards[(i - 1) * 8 + (j - 7)] = new Card(j.ToString(), colours[i]);
                }
                for (int k = 4; k > 0; k--)
                {
                    listOfCards.Add(new Card(colours[i], cardValues[k], "SedmaGame"));
                    //_cards[i * 8 - k] = new Card(cardValues[k], colours[i]);
                }
            }
            return new CardPackage(listOfCards);
        }
        void InitDictionaryValues(Dictionary<int, string> colours, Dictionary<int, string> cardValues)
        {
            colours.Add(1, "cerven");
            colours.Add(2, "zelen");
            colours.Add(3, "gula");
            colours.Add(4, "zalud");

            cardValues.Add(1, "eso");
            cardValues.Add(2, "kral");
            cardValues.Add(3, "hornik");
            cardValues.Add(4, "dolnik");
        }
    }
}
