using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Cards : List<Card>, ICloneable
    {


        /// <summary>
        /// Creates a clone for the list of cards
        /// </summary>
        /// <returns>a clones cards list</returns>
        public object Clone()
        {
            Cards cards = new Cards();
            foreach (Card sourceCard in this)
            {
                cards.Add((Card)sourceCard.Clone());

            }
            return cards;
        }

        /// copyto method for copying card instances into another Cards
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        public void CopyTo(Cards targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }



        //gets a card based on int number
        //public Card GetCard(int cardNum, Cards cards)
        //{
        //
        //    if (cardNum >= 0 && cardNum <= 51)
        //        return cards[cardNum];
        //    else
        //        throw (new System.ArgumentOutOfRangeException("Card rank ", cardNum,
        //               "Value must be between 0 and 51."));
        //}


    }
}
