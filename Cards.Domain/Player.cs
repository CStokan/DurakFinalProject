using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardsLibrary
{
    public class Player 
    {

        private Cards cards = new Cards();
        private int playersCardsNum = 0;

        /// <summary>
        /// Parameterized constructor 
        /// </summary>
        /// <param name="newCards">Hands of list of cards to player</param>
        public Player(Cards newCards)
        {
            cards = newCards;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Player()
        {
        }

        /// <summary>
        /// Adds a card to the players hand
        /// </summary>
        /// <param name="cardToAdd">The card to add</param>
        public void AddCardToPlayer(Card cardToAdd)
        {
            cards.Add(cardToAdd);
            playersCardsNum = cards.Count();
        }

        /// <summary>
        /// Adds the specified cards to the players hand
        /// </summary>
        /// <param name="cardsToAdd">Cards to give player</param>
        public void AddCardsToPlayer(Cards cardsToAdd)
        {

            for (int i = 0; i < cardsToAdd.Count(); i++)
            {
                cardsToAdd.Add(cardsToAdd[i]);
            }

            playersCardsNum = cards.Count();
        }

        /// <summary>
        /// This will remove a players cards from their hands
        /// </summary>
        /// <param name="cardsToRemove">The cards to remove</param>
        public void RemoveCardsFromPlayer(Cards cardsToRemove)
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
        /// An overrided ToString to print the players hand 
        /// </summary>
        /// <returns>A string of the players hand</returns>
        public override string ToString()
        {
            String playerToString = "";
            playerToString += "Cards: \n";
            for (int i = 0; i < this.cards.Count(); i++)
            {
                Card tempCard = this.GetCard(i);
                playerToString += tempCard.ToString();
                if (i != 51)
                    playerToString += "\n";

            }

            return playerToString;
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
