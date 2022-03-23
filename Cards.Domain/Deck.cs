using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Deck 
    {
        /// <summary>
        /// Private variables
        /// </summary>
        private Cards cards = new Cards();

        int startDeckAt;

        public Cards Cards
        {
            get { return cards; }
            set
            {
                cards = value;
            }
        }


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

        //Parameterized Constructor (CardList), sets private attribute cardlist to new carlist.
        private Deck(Cards newCards)
        {
            cards = newCards;
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
                    cards.Add(new Card((SuitEnum)suitVal, (RankEnum)rankVal));
                }
            }
        }

        /// <summary>
        /// Overridden to string method that prints a deck in a string format
        /// </summary>
        /// <returns>A formatted deck string</returns>
        public override string ToString()
        {
            string deckToString = "";

            for (int i = 0; i < this.DeckCount(); i++)
            {
                Card card = this.GetCard(i);
                deckToString += card.ToString() + "\n";
            }
            return deckToString;
        }

        /// <summary>
        /// SHuffles the deck of cards depending on where the deck is shuffled
        /// </summary>
        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[startDeckAt];
            Random sourceGen = new Random();
            for (int i = 0; i < startDeckAt; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(startDeckAt);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(Cards[sourceCard]);
            }
            newDeck.CopyTo(Cards);
        }


        /// <summary>
        /// Allows the deck to use the cards.Count method
        /// </summary>
        /// <returns>The count of cards in a deck</returns>
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

            startDeckAt = deckSize;
            if(startDeckAt == 52)
            {
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    for (int rankVal = 1; rankVal < 14; rankVal++)
                    {
                        cards.Add(new Card((SuitEnum)suitVal, (RankEnum)rankVal));
                    }
                }
            }
            else if(startDeckAt == 36)
            {
                
                for (int suitVal = 0; suitVal < 4; suitVal++)
                {
                    cards.Add(new Card((SuitEnum)suitVal, (RankEnum.Ace)));
                    for (int rankVal = 6; rankVal < 14; rankVal++)
                    {
                        cards.Add(new Card((SuitEnum)suitVal, (RankEnum)rankVal));
                    }
                }
            }
        }

        /// <summary>
        /// This is a function that draws a certain amount of cards
        /// </summary>
        /// <param name="numberOfCards">How many cards do you want to draw</param>
        /// <returns>Drawn Cards</returns>
        public Cards DrawCards(int numberOfCards)
        {
            Cards cardsToDraw = new Cards();

            for (int i = 0; i < numberOfCards; i++)
            {
                cardsToDraw.Add(cards.ElementAt(0));
                cards.RemoveAt(0);
            }
            return cardsToDraw;
        }

        /// <summary>
        /// Draws a card from a deck
        /// </summary>
        /// <returns>The card at the top of the deck</returns>
        public Card DrawCard()
        {

            Card card;
            // Draw first card then remove it
            card = cards.First();
            cards.RemoveAt(0);
            return card;
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
