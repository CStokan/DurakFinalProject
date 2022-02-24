using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Card : ICloneable
    {
        public readonly SuitEnum suit;
        public readonly RankEnum rank;

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
        private Card() { }

     

        public override string ToString()
        {
            return "The " + rank + " of " + suit + "s";
        }


        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
