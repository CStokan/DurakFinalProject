using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Deck
    {
        //private Card[] cards;
        private Cards cards = new Cards();


        /// <summary>
        /// Nondefault constructor. Allows aces to be set high.
        /// </summary>
        public Deck(bool isAceHigh) : this()
        {
            Card.isAceHigh = isAceHigh;
        }
        /// <summary>
        /// Nondefault constructor. Allows a trump suit to be used.
        /// </summary>
        public Deck(bool useTrumps, SuitEnum trump) : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }
        /// <summary>
        /// Nondefault constructor. Allows aces to be set high and a trump suit
        /// to be used.
        /// </summary>
        public Deck(bool isAceHigh, bool useTrumps, SuitEnum trump) : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        /// <summary>
        /// Default constructor for deck
        /// </summary>
        public Deck()
        {

            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    //cards[suitVal * 13 + rankVal - 1] = new Card((Suit)suitVal, (Rank)rankVal);
                    cards.Add(new Card((SuitEnum)suitVal, (RankEnum)rankVal));
                }
            }
        }

        //to string method shows cards in deck as a string
        public void DeckToString(Deck newDeck)
        {
            // Loop thru deck and get the card and toStirng and output to console
            for (int i = 0; i < newDeck.DeckCount(); i++)
            {
                Card tempCard = newDeck.GetCard(i);
                Console.WriteLine(tempCard.ToString());
            }
        }

        public int DeckCount()
        {
            return cards.Count;
        }


        /// <summary>
        /// Param constructor for getting the desired deck size
        /// </summary>
        /// <param name="deckSize"></param>
        public Deck(int deckSize)
        {
            int startDeckAt;

            if(deckSize == 52)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 1; rankVal < 14; rankVal++)
                    {
                        cards.Add(new Card((SuitEnum)suitVal, (RankEnum)rankVal));
                    }
                }
            }
            else if(deckSize == 36)
            {
                startDeckAt = 5;
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = startDeckAt; rankVal < 14; rankVal++)
                    {
                        cards.Add(new Card((SuitEnum)suitVal, (RankEnum)rankVal));
                    }
                }
            }

 
        }

        /// <summary>
        /// Gets a specified amount of cards
        /// </summary>
        /// <param name="cardNum">amount of cards</param>
        /// <returns>A list of cards</returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw
                    (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                          "Value must be between 0 and 51."));
        }

    }
}
