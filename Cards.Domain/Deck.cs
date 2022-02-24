using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Deck
    {
        private Cards toDeck = new Cards();

        public Deck()
        {
            
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    toDeck.Add(new Card((SuitEnum)suitVal, (RankEnum)rankVal));
                }
            }
        }

        /// <summary>
        /// Param constructor for getting the desired deck size
        /// </summary>
        /// <param name="deckSize"></param>
        public Deck(int deckSize)
        {
            int startDeckAt = 5;
            
            
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    toDeck.Add(new Card((SuitEnum)suitVal, (RankEnum)rankVal));
                }
            }
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return toDeck[cardNum];
            else
                throw
                    (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                          "Value must be between 0 and 51."));
        }

    }
}
