using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CardsLibrary
{
    public class Cards : ObservableCollection<Card>, ICloneable
    {

        /// <summary>
        /// Creates a clone for the list of cards
        /// </summary>
        /// <returns>a clones cards list</returns>
        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());
            }
            return newCards;
        }


        /// <summary>
        /// Cards to String override
        /// </summary>
        /// <returns>Cards but to string</returns>
        public override string ToString()
        {
            String cardsToString = "";

            cardsToString += "\n\nCards\n";
            for (int i = 0; i < this.Count(); i++)
            {
                Card card = this.GetCard(i, this);
                cardsToString += card.ToString() + "\n";
                if (i != 51)
                    cardsToString += "\n";

            }

            return cardsToString;
        }

        /// <summary>
        /// Utility method for copying card instances into another Cards
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        /// </summary>
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

 


        //gets a card based on int number
        public Card GetCard(int cardToGet, Cards cards)
        {

            if (cardToGet >= 0 && cardToGet <= 51)
                return cards[cardToGet];
            else
                throw (new System.ArgumentOutOfRangeException("Card: ", cardToGet,
                       "Value must be between 0 and 51."));
        }



    }
}
