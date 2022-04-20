using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardsLibrary
{
    public class Hand : ObservableCollection<Card>
    {

        private Cards cards = new Cards();
        private Card card = new Card();
        private int handsCardsNum = 0;
        private List<RankEnum> ranks = new List<RankEnum>();

        public Cards Cards
        {
            get { return cards; }
            set
            {
                cards = value;
            }
        }

        public List<RankEnum> Ranks
        {
            get { return ranks; }
            set { ranks = value; }
        }

        /// <summary>
        /// Parameterized constructor 
        /// </summary>
        /// <param name="newCards">Hands of list of cards to Hand</param>
        public Hand(Cards newCards)
        {
            cards = newCards;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Hand()
        {
            Cards = new Cards();
        }

        public int HandCount()
        {
            return cards.Count;
        }

        /// <summary>
        /// Adds a card to the Hands hand
        /// </summary>
        /// <param name="cardToAdd">The card to add</param>
        public void AddCardToHand(Card cardToAdd)
        {
            cards.Add(cardToAdd);
            handsCardsNum = cards.Count();
        }

        public void RemoveCardFromHand(Card cardToAdd)
        {
            cards.Remove(cardToAdd);
            handsCardsNum = cards.Count();
        }

        /// <summary>
        /// Adds the specified cards to the Hands hand
        /// </summary>
        /// <param name="cardsToAdd">Cards to give Hand</param>
        public void AddCardsToHand(Cards cardsToAdd)
        {

            for (int i = 0; i < cardsToAdd.Count(); i++)
            {
                cardsToAdd.Add(cardsToAdd[i]);
            }

            handsCardsNum = cards.Count();
        }

        /// <summary>
        /// This will remove a Hands cards from their hands
        /// </summary>
        /// <param name="cardsToRemove">The cards to remove</param>
        public void RemoveCardsFromHand(Cards cardsToRemove)
        {
            for (int i = 0; i < cardsToRemove.Count(); i++)
            {
                cards.Remove(cardsToRemove[i]);
            }
        }


        /// <summary>
        /// Gets a specified amount of cards
        /// </summary>
        /// <param name="cardNum">amount of cards</param>
        /// <returns>A list of cards</returns>
        public Card GetCard(int cardsToGet)
        {
            if (cardsToGet >= 0 && cardsToGet <= 51)
                return cards[cardsToGet];
            else
                throw
                    (new System.ArgumentOutOfRangeException("Card: ", cardsToGet,
                          " must be between 0 and 51."));
        }



        /// <summary>
        /// An overrided ToString to print the Hands hand 
        /// </summary>
        /// <returns>A string of the Hands hand</returns>
        public override string ToString()
        {
            String handToString = "";
            handToString += "Cards: \n";
            for (int i = 0; i < this.cards.Count(); i++)
            {
                Card tempCard = this.GetCard(i);
                handToString += tempCard.ToString();
                if (i != 51)
                    handToString += "\n";

            }

            return handToString;
        }

        /// <summary>
        /// This will take a card at a given element
        /// </summary>
        /// <param name="cardToTake"></param>
        /// <returns>The card at the given index</returns>
        public Card ChooseCardFromHand(int cardToTake)
        {
            Card card;
            card = cards.ElementAt(cardToTake);

            return card;
        }
    }
}
