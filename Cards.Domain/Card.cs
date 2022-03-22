using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CardsLibrary
{
    public class Card : ICloneable, IComparable
    {

        /// <summary>
        /// Flag for trump usage. If true, trumps are valued higher
        /// than cards of other suits.
        /// </summary>
        public static bool useTrumps = false;
        /// <summary>
        /// Trump suit to use if useTrumps is true.
        /// </summary>
        public static SuitEnum trump = SuitEnum.Clubs;
        /// <summary>
        /// Flag that determines whether aces are higher than kings or lower
        /// than deuces.
        /// </summary>
        public static bool isAceHigh = true;


        protected SuitEnum mySuit;
        public SuitEnum Suit
        {
            get { return mySuit; }
            set { mySuit = value; }
        }
        protected RankEnum myRank;
        public RankEnum Rank
        {
            get { return myRank; }
            set { myRank = value; }
        }

        protected int myValue;
        public int value
        {
            get { return myValue; }
            set { myValue = value; }
        }
              
        protected bool faceUp = false;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        /// <summary>
        /// Clone Method
        /// ToSupport the ICloneable interface
        /// </summary>
        /// <returns></returns>
        public object Clone() => this.MemberwiseClone();

        /// <summary>
        /// Creates a card 
        /// </summary>
        /// <param name="newSuit">Card suit</param>
        /// <param name="newRank">Card number</param>
        public Card(SuitEnum suit = SuitEnum.Clubs, RankEnum rank = RankEnum.Two)
        {
            this.mySuit = suit;
            this.myRank = rank;
            this.myValue = (int)rank;
        }

        /// <summary>
        /// CompareTo Mthod
        /// Card-Specific comparison method used to sort card instance
        /// </summary>
        public virtual int CompareTo(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Unable to compare a card to a null object.");
            }
            Card compareCard = obj as Card;

            // if the conversion worked
            if (compareCard != null)
            {
                // Compare based on value first then suit
                int thisSort = this.myValue * 10 + (int)this.mySuit;
                int compareCardSort = compareCard.myValue * 10 + (int)compareCard.mySuit;
                return (thisSort.CompareTo(compareCardSort));
            }
            else
            {
                throw new ArgumentException("Object being compared cannot be converted to a card.");
            }
        }

        // Default constructor
        public Card() { myRank = RankEnum.Two; }

        /// <summary>
        /// Override == method to check if the 2 cards are same mySuit / same rank
        /// </summary>
        /// <param name="card1">A card</param>
        /// <param name="card2">A Card</param>
        /// <returns>True or false</returns>
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.mySuit == card2.mySuit) && (card1.myRank == card2.myRank);
        }

        /// <summary>
        /// Override != method to check if the 2 cards are not same mySuit / same rank
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
            return this.myValue * 10 + (int)this.mySuit;
        }

        /// <summary>
        /// Gets the image associate with the card from the resource file.
        /// </summary>
        /// <returns></returns>
        public Image GetCardImage()
        {
            string imageName; // The name of the image in the resource file
            Image cardImage; // Holds the image

            if (!faceUp)
            {
                // Sets the image name to Back
                imageName = "Back";
            }
            else// Otherwise the card is face up
            {
                // Set the image name to {suit}_{rank}
                imageName = mySuit.ToString() +"_" + myRank.ToString();
            }

            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;

            return cardImage;
            
        }



        public static bool operator >(Card card1, Card card2)
        {
            if (card1.mySuit == card2.mySuit)
            {
                if (isAceHigh)
                {
                    if (card1.myRank == RankEnum.Ace)
                    {
                        if (card2.myRank == RankEnum.Ace)
                            return false;
                        else
                            return true;
                    }
                    else
                    {
                        if (card2.myRank == RankEnum.Ace)
                            return false;
                        else
                            return (card1.myRank > card2?.myRank);
                    }
                }
                else
                {
                    return (card1.myRank > card2.myRank);
                }
            }
            else
            {
                if (useTrumps && (card2.mySuit == Card.trump))
                    return false;
                else
                    return true;
            }
        }

        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.mySuit == card2.mySuit)
            {
                if (isAceHigh)
                {
                    if (card1.myRank == RankEnum.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.myRank == RankEnum.Ace)
                            return false;
                        else
                            return (card1.myRank >= card2.myRank);

                    }
                }
                else
                {
                    return (card1.myRank >= card2.myRank);
                }
            }
            else
            {
                if (useTrumps && (card2.mySuit == Card.trump))
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
            return "The " + myRank + " of " + mySuit + "s";
        }



    }
}
