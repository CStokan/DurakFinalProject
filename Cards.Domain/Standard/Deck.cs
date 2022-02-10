using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards.Domain.Standard
{

    public class Deck : IDeck
    {
        /// <summary>
        /// Default constructor that calls reset and creates a fresh deck
        /// </summary>
        public Deck()
        {
            Reset();
        }
        
        /// <summary>
        /// Automatic property for setting and getting the list of cards
        /// </summary>
        public List<Card> Cards { get; set; }


        /// <summary>
        /// Reset will reset a shuffled deck to it's original state
        /// </summary>
        public void Reset()
        {
            Cards = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 9)
                                    .Select(c => new Card()
                                    {
                                        Suit = (Suit)s,
                                        CardNumber = (CardNumber)c
                                    }
                                            )
                            )
                   .ToList();
        }

        /// <summary>
        /// This will shuffle a deck of cards to a random number
        /// </summary>
        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid())
                         .ToList();
        }


        /// <summary>
        /// This uses the ICard interface and returns the top card from the top of the deck
        /// </summary>
        /// <returns>A card from the top of the deck</returns>
        public ICard TakeCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.Remove(card);

            return card;
        }
        
        /// <summary>
        /// Creates an array of cards from the top of the deck depending on the number entered
        /// </summary>
        /// <param name="numberOfCards">The number of cards to be taken from the deck</param>
        /// <returns>The amount of cards to return</returns>
        public IEnumerable<ICard> TakeCards(int numberOfCards)
        {
            var cards = Cards.Take(numberOfCards);

            var takeCards = cards as Card[] ?? cards.ToArray();
            Cards.RemoveAll(takeCards.Contains);

            return takeCards;
        }
    }
}