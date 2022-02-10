namespace Cards.Domain.Standard
{
    public class Card : ICard
    {
        /// <summary>
        /// Auto property for suit
        /// </summary>
        public Suit Suit { get; set; }
        /// <summary>
        /// Auto property for CardNumber
        /// </summary>
        public CardNumber CardNumber { get; set; }

        /// <summary>
        /// Overidden ToString method that will print the details of the cards
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Your card is a " + this.CardNumber + " of " + this.Suit;
        }


    }
}