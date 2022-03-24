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

        Deck myDeck = new Deck();

        static Hand player1Hand = new Hand();
        static Hand player2Hand = new Hand();

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
            // Create a new deck
            myDeck = new Deck(36);
            myDeck.Shuffle();



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
                newCardbox1.FaceUp = true;
                flowComputersHand.Controls.Add(newCardbox1);

            }
        }


        private void PlayerClickEvent(object sender, EventArgs e)
        {
            CardBox.CardBox cardBoxClicked = (CardBox.CardBox)sender;
            Card cardClicked = cardBoxClicked.Card;

            flowRiverHand.Controls.Add(cardBoxClicked); 

            lblTrumpCard.Text = player1.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            DealCards(player1, player2);

        }
    }
}
