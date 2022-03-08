using CardsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLibrary
{
    public class Player : Hand
    {

        private Hand hand = new Hand();

        /// <summary>
        /// default player construct 
        /// </summary>
        /// <param name="playerHand"></param>
        public Player(Hand playerHand)
        {
            hand = playerHand;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Player()
        {
        }

    }
}
