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



            for (int i = 0; i < 6; i++)
            {
                // Deal to player
                CardBox.CardBox newCardbox = new CardBox.CardBox();
                
                player1.AddCardToHand(myDeck.DrawCard());
                newCardbox.Card = player1.ChooseCardFromHand(i);
                newCardbox.FaceUp = true;
                flowPlayersHand.Controls.Add(newCardbox);
                newCardbox.Click += PlayerClickEvent;

                // Deal to computer
                CardBox.CardBox newCardbox1 = new CardBox.CardBox();
                player2.AddCardToHand(myDeck.DrawCard());
                newCardbox1.Card = player2.ChooseCardFromHand(i);
                newCardbox1.FaceUp = false;
                flowComputersHand.Controls.Add(newCardbox1);

            }
            // Trump Card
            CardBox.CardBox trumpCardBox = new CardBox.CardBox();

            trumpCard.AddCardToHand(myDeck.DrawCard());
            trumpCardBox.Card = trumpCard.ChooseCardFromHand(0);
            trumpCardBox.FaceUp = true;
            flpTrumpCard.Controls.Add(trumpCardBox);
        }

        private void ComputerMove()
        {


            CardBox.CardBox newCardbox1 = new CardBox.CardBox();

            
            // Take the card at 0 and remove it from computers hand
            newCardbox1.Card = player2.ChooseCardFromHand(0);
            flowRiverHand.Controls.Add(newCardbox1);

            riverHand.AddCardToHand(player2.ChooseCardFromHand(0));

            flowComputersHand.Controls.RemoveAt(0);
            player2.RemoveCardFromHand(player2.GetCard(0));

            flowComputersHand.Controls.Remove(newCardbox1);
            newCardbox1.FaceUp = true;

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

            RiverLabel.Text = riverHand.ToString();
            PlayerLabel.Text = player1.ToString();
            ComputerLabel.Text = player2.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Emptying labels so there is no stacking on reset
            RiverLabel.Text = String.Empty;
            PlayerLabel.Text = String.Empty;
            ComputerLabel.Text = String.Empty;

            // Creating new player hands and trump on reset
            player1Hand = new Hand();
            player2Hand = new Hand();
            riverHand = new Hand();
            trumpCard = new Hand();

            // Creating new player hands so the cards switch on reset
            player1 = new Player(player1Hand);
            player2 = new Player(player2Hand);

            // Create a new deck
            myDeck = new Deck(36);
            myDeck.Shuffle();
            DealCards(player1, player2);
            flowRiverHand.Controls.Clear();



        }
    }
}
