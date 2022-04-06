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

        public void UpdatePlayableCards(Game game)
        {
            playableCards.Clear();

            if (status == Statuses.Attacking && firstTurn)
            {
                for (int i = 0; i < Hand.Count; i++)
                {
                    playableCards.Add(Hand[i]);
                }
            }
            else if (status == Statuses.Attacking && firstTurn == false)
            {
                for (int i = 0; i < Hand.Count; i++)
                {
                    if (game.River.Ranks.Contains(Hand[i].Rank))
                    {
                        playableCards.Add(Hand[i]);
                    }
                }
            }
            else if (status == Statuses.Defending)
            {
                for (int i = 0; i < Hand.Count; i++)
                {
                    if (game.River.Count > 0)
                    {
                        if (Hand[i].Suit == game.trumpSuit ||
                            ((Hand[i].Rank == game.River[game.River.Count - 1].Rank) && firstTurn == true) ||
                            ((Hand[i].Suit == game.River[game.River.Count - 1].Suit) && Hand[i] > game.River[game.River.Count - 1]))
                        {
                            playableCards.Add(Hand[i]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Player()
        {

        }

    }
}
