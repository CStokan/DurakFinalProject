using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Cards : CollectionBase, ICloneable
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

        public void Add(Card newCard) => List.Add(newCard);

        public void Remove(Card oldCard) => List.Remove(oldCard);


        /// <summary>
        /// Returns a card at this index
        /// </summary>
        /// <param name="cardIndex">Index of card</param>
        /// <returns>card at the index</returns>
        public Card this[int cardIndex]
        {
            get { return (Card)List[cardIndex]; }
            set { List[cardIndex] = value; }
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

        /// <summary>
        /// Check to see if the Cards collection contains a particular card.
        /// This calls the Contains() method of the ArrayList for the collection,
        /// which you access through the InnerList property.
        /// </summary>
        public bool Contains(Card card) => InnerList.Contains(card);


    }
}
