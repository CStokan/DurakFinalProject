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
        private Hand handToPlay = new Hand();
        private bool isAttacking;

        public Hand Hand
        {
            get { return hand; }
            set
            {
                hand = value;
            }
        }

        public Hand HandToPlay
        {
            get { return handToPlay; }
            set
            {
                handToPlay = value;
            }
        }


        public bool IsAttacking
        {
            get { return isAttacking; }
            set
            {
                isAttacking = value;
            }
        }

        /// <summary>
        /// default player construct 
        /// </summary>
        /// <param name="playerHand"></param>
        public Player(Hand playerHand, bool isAttack)
        {
            hand = playerHand;
            isAttacking = isAttack;
        }

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
