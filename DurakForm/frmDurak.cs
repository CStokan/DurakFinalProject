using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardsLibrary;

namespace DurakForm
{
    public partial class frmDurakGame : Form
    {

        Deck myDeck = new Deck(36);

        static Hand player1Hand = new Hand();
        static Hand player2Hand = new Hand();
        public Hand riverHand = new Hand();
        public Hand trumpCard = new Hand();
        bool firstTurn;

        Player player1 = new Player(player1Hand);
        Player player2 = new Player(player2Hand);
        
       


        public frmDurakGame()
        {
            InitializeComponent();
            
            
        }

        private void frmDurakGame_Load(object sender, EventArgs e)
        {
            
        }

        private void playerClickCard(object sender, EventArgs e)
        {
            CardBox.CardBox cardBoxClicked = (CardBox.CardBox)sender;
            Card cardClicked = cardBoxClicked.Card;

            
        }

        public void DisplayCards()
        {
            
        }

        public void DealCards(Player player1, Player player2)
        {
            // Clear controls
            flowPlayersHand.Controls.Clear();
            flowComputersHand.Controls.Clear();
            flpTrumpCard.Controls.Clear();

            int player1Hand = player1.HandCount();
            int player2Hand = player2.HandCount();

            for (int i = 0; i < (6 - player1Hand); i++)
            {
                // Deal to player
                CardBox.CardBox newCardbox = new CardBox.CardBox();
                
                player1.AddCardToHand(myDeck.DrawCard());
                newCardbox.Card = player1.ChooseCardFromHand(i);
                newCardbox.FaceUp = true;
                flowPlayersHand.Controls.Add(newCardbox);
                newCardbox.Click += PlayerClickEvent;
            }
            for (int i = 0; i < (6 - player2Hand); i++)
            {
                // Deal to computer
                CardBox.CardBox newCardbox1 = new CardBox.CardBox();
                player2.AddCardToHand(myDeck.DrawCard());
                newCardbox1.Card = player2.ChooseCardFromHand(i);
                newCardbox1.FaceUp = true;
                flowComputersHand.Controls.Add(newCardbox1);
            }

            

        }

        public void GetTrumpCard()
        {
            // Trump Card
            CardBox.CardBox trumpCardBox = new CardBox.CardBox();

            trumpCard.AddCardToHand(myDeck.DrawCard());
            trumpCardBox.Card = trumpCard.ChooseCardFromHand(0);
            trumpCardBox.FaceUp = true;
            flpTrumpCard.Controls.Add(trumpCardBox);
        }



        public void PickUpToSix(Deck deck, Player player1, Player computerPlayer)
        {
            int player1Hand = player1.HandCount();
            int player2Hand = computerPlayer.HandCount();

            for (int i = 0; i < (6 - player1Hand); i++)
            {
                // Deal to player
                CardBox.CardBox newCardbox = new CardBox.CardBox();
                player1.AddCardToHand(myDeck.DrawCard());
                newCardbox.Card = player1.ChooseCardFromHand(i);
                newCardbox.FaceUp = true;
                flowPlayersHand.Controls.Add(newCardbox);
                newCardbox.Click += PlayerClickEvent;
            }
            for (int i = 0; i < (6 - player2Hand); i++)
            {
                // Deal to computer
                CardBox.CardBox newCardbox1 = new CardBox.CardBox();
                
                computerPlayer.AddCardToHand(myDeck.DrawCard());
                newCardbox1.Card = computerPlayer.ChooseCardFromHand(i);
                newCardbox1.FaceUp = true;
                flowComputersHand.Controls.Add(newCardbox1);
            }
        }


        /// <summary>
        /// This is how the computer determines what card to play
        /// </summary>
        private void ComputerMove()
        {
            RiverLabel.Text = trumpCard.ToString();

            CardBox.CardBox newCardbox1 = new CardBox.CardBox();
            for (int i = 0; i < player2.HandCount(); i++)
            {
                int cardCount = 0;

                // Defending
                if (riverHand.HandCount() > 0)
                {
                    if (player2.GetCard(i).Suit == trumpCard.GetCard(0).Suit && player2.GetCard(i).Suit > riverHand.GetCard(riverHand.HandCount() - 1).Suit ||
                        ((player2.GetCard(i).Suit == riverHand.GetCard(riverHand.HandCount() -1).Suit) && player2.GetCard(i) > riverHand.GetCard(riverHand.HandCount() - 1)))
                    {
                        newCardbox1.Card = player2.ChooseCardFromHand(i);
                        flowRiverHand.Controls.Add(newCardbox1);
                        riverHand.AddCardToHand(player2.ChooseCardFromHand(i));
                        flowComputersHand.Controls.RemoveAt(i);
                        player2.RemoveCardFromHand(player2.GetCard(i));
                        flowComputersHand.Controls.Remove(newCardbox1);
                        newCardbox1.FaceUp = true;
                        cardCount++;
                        break;
                    }
                }
                
            }

            // If the player succeeds in an attack
            if (riverHand.HandCount() % 2 == 0)
            {
                RiverLabel.Text = "Even";
            } else
            {
                RiverLabel.Text = "Odd";


                while (riverHand.HandCount() > 0)
                {
                    int i = 0;
                    CardBox.CardBox newCardbox2 = new CardBox.CardBox();
                    newCardbox2.Card = riverHand.GetCard(i);
                    flowComputersHand.Controls.Add(newCardbox2);
                    player2.AddCardToHand(riverHand.GetCard(i));
                    flowRiverHand.Controls.RemoveAt(i);
                    riverHand.RemoveCardFromHand(riverHand.GetCard(i));
                    flowRiverHand.Controls.Remove(newCardbox1);
                    newCardbox2.FaceUp = true;
                    i++;
                }

                PickUpToSix(myDeck, player1, player2);
            }

        }

        /// <summary>
        /// Takes a card from a player and removes it then adds to riverhand
        /// </summary>
        /// <param name="player"></param>
        /// <param name="cardToRemove"></param>
        private void RemoveFromPlayerAddToRiver(Player player, Card cardToRemove)
        {
            player.RemoveCardFromHand(cardToRemove);
            riverHand.AddCardToHand(cardToRemove);
            

        }

        private void PlayerClickEvent(object sender, EventArgs e)
        {
            CardBox.CardBox cardBoxClicked = (CardBox.CardBox)sender;
            Card cardClicked = cardBoxClicked.Card;

            if (player1.IsAttacking && firstTurn)
            {
                // This is created to stop the river card from being clickable
                CardBox.CardBox riverCardBox = new CardBox.CardBox();
                riverCardBox.Card = cardBoxClicked.Card;
                riverCardBox.FaceUp = true;

                // Remove clicked card from player hand
                // Add card to river hand
                RemoveFromPlayerAddToRiver(player1, cardClicked);
                // Move it to flowBox
                flowPlayersHand.Controls.Remove(cardBoxClicked);
                flowRiverHand.Controls.Add(riverCardBox);

                ComputerMove();
            }
            else if (player1.IsAttacking && firstTurn == false)
            {
                // This is created to stop the river card from being clickable
                CardBox.CardBox riverCardBox = new CardBox.CardBox();
                riverCardBox.Card = cardBoxClicked.Card;
                riverCardBox.FaceUp = true;

                // Remove clicked card from player hand
                // Add card to river hand
                RemoveFromPlayerAddToRiver(player1, cardClicked);
                // Move it to flowBox
                flowPlayersHand.Controls.Remove(cardBoxClicked);
                flowRiverHand.Controls.Add(riverCardBox);

                ComputerMove();
            }
            else if (!player1.IsAttacking)
            {
                if (riverHand.HandCount() > 0)
                {
                    if (cardClicked.Suit == trumpCard.GetCard(0).Suit && cardClicked.Suit > riverHand.GetCard(riverHand.HandCount() - 1).Suit ||
                        ((cardClicked.Suit == riverHand.GetCard(riverHand.HandCount() - 1).Suit) && cardClicked > riverHand.GetCard(riverHand.HandCount() - 1)))
                    {
                        // This is created to stop the river card from being clickable
                        CardBox.CardBox riverCardBox = new CardBox.CardBox();
                        riverCardBox.Card = cardBoxClicked.Card;
                        riverCardBox.FaceUp = true;

                        // Remove clicked card from player hand
                        // Add card to river hand
                        RemoveFromPlayerAddToRiver(player1, cardClicked);
                        // Move it to flowBox
                        flowPlayersHand.Controls.Remove(cardBoxClicked);
                        flowRiverHand.Controls.Add(riverCardBox);

                        ComputerMove();
                    }
                }

            }

            RiverLabel.Text = riverHand.ToString();
            PlayerLabel.Text = player1.ToString();
            ComputerLabel.Text = player2.ToString();

            CardsRemainingLabel.Text = "Cards Remaining: " + myDeck.DeckCount();  


        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            // Emptying labels so there is no stacking on reset
            RiverLabel.Text = String.Empty;
            PlayerLabel.Text = String.Empty;
            ComputerLabel.Text = String.Empty;
            testlabel.Text = String.Empty;

            // Creating new player hands and trump on reset
            player1Hand = new Hand();
            player2Hand = new Hand();
            riverHand = new Hand();
            trumpCard = new Hand();
            bool firstTurn;


            // Creating new player hands so the cards switch on reset
            player1 = new Player(player1Hand, true);
            player2 = new Player(player2Hand, false);

            // Create a new deck
            myDeck = new Deck(36);
            myDeck.Shuffle();
            DealCards(player1, player2);
            GetTrumpCard();
            flowRiverHand.Controls.Clear();

        }
    }
}
