using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Card 
    {

        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;
        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static SuitEnum trump = SuitEnum.Club;
        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;


        public readonly SuitEnum suit;
        public readonly RankEnum rank;
        public object Clone() => MemberwiseClone();

        /// <summary>
        /// Creates a card 
        /// </summary>
        /// <param name="newSuit">Card suit</param>
        /// <param name="newRank">Card number</param>
        public Card(SuitEnum newSuit, RankEnum newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        // Default constructor
        public Card() { }

        /// <summary>
        /// Override == method to check if the 2 cards are same suit / same rank
        /// </summary>
        /// <param name="card1">A card</param>
        /// <param name="card2">A Card</param>
        /// <returns>True or false</returns>
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }

        /// <summary>
        /// Override != method to check if the 2 cards are not same suit / same rank
        /// </summary>
        /// <param name="card1">A card</param>
        /// <param name="card2">A Card</param>
        /// <returns>Returns true if not the same</returns>
        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }

        /// <summary>
        /// If card is equal to card
        /// </summary>
        /// <param name="card">Card in question</param>
        /// <returns>true or false</returns>
        public override bool Equals(object card) => this == (Card)card;


        /// <summary>
        /// Gets the hashcode of a card
        /// </summary>
        /// <returns>a hashed number that represents a specific card</returns>
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }
                


        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == RankEnum.Ace)
                    {
                        if (card2.rank == RankEnum.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.rank == RankEnum.Ace)
                            return false;
                        else
                            return (card1.rank > card2?.rank);
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == RankEnum.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == RankEnum.Ace)
                            return false;
                        else
                            return (card1.rank >= card2.rank);
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator <=(Card card1, Card card2)
            => !(card1 > card2);

        public static bool operator <(Card card1, Card card2)
            => !(card1 >= card2);

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }



    }
}
