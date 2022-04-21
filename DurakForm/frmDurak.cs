using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        DateTime today = DateTime.Now;
        static Hand player1Hand = new Hand();
        static Hand player2Hand = new Hand();
        public Hand riverHand = new Hand();
        public Hand trumpCard = new Hand();
        public int deckSize;
        bool firstTurn;
        StreamWriter file;
        public string userID;

        


        Player player1 = new Player(player1Hand);
        Player player2 = new Player(player2Hand);




        public frmDurakGame(string user)
        {
            InitializeComponent();
            userID = user;
            

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

        public void TurnChoice()
        {
            Random rnd = new Random();
            int TurnChoice = rnd.Next(0, 2);

            if (TurnChoice == 0)
            {
                player1.IsAttacking = true;
                player2.IsAttacking = false;
            }
            else if (TurnChoice == 1)
            {
                player2.IsAttacking = true;
                player1.IsAttacking = false;
            }
        }


        public void SwapTurns()
        {
            if (player1.IsAttacking)
            {
                player1.IsAttacking = false;
                player2.IsAttacking = true;
                firstTurn = true;

                lblAttack.Visible = false;
                lblDefend.Visible = true;

                ComputerMove();
            }
            else if (player1.IsAttacking == false)
            {
                player1.IsAttacking = true;
                player2.IsAttacking = false;
                firstTurn = true;

                lblAttack.Visible = true;
                lblDefend.Visible = false;
            }

            PickUpToSix(myDeck, player1, player2);
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
            trumpCardBox.Size = new Size(75, 107);
            flpTrumpCard.Controls.Add(trumpCardBox);
            
        }




        /// <summary>
        /// This method is called when the game needs to refresh
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="player1"></param>
        /// <param name="computerPlayer"></param>
        public void PickUpToSix(Deck deck, Player player1, Player computerPlayer)
        {
            int player1Hand = player1.HandCount();
            int player2Hand = computerPlayer.HandCount();

            for (int i = 0; i < (6 - player1Hand); i++)
            {
                // Deal to player
                CardBox.CardBox newCardbox = new CardBox.CardBox();
                player1.AddCardToHand(myDeck.DrawCard());
                newCardbox.Card = player1.ChooseCardFromHand(player1.HandCount() - 1);
                newCardbox.FaceUp = true;
                flowPlayersHand.Controls.Add(newCardbox);
                newCardbox.Click += PlayerClickEvent;
            }
            for (int i = 0; i < (6 - player2Hand); i++)
            {
                // Deal to computer
                CardBox.CardBox newCardbox1 = new CardBox.CardBox();

                computerPlayer.AddCardToHand(myDeck.DrawCard());
                newCardbox1.Card = computerPlayer.ChooseCardFromHand(computerPlayer.HandCount() - 1);
                newCardbox1.FaceUp = true;
                flowComputersHand.Controls.Add(newCardbox1);
            }
        }


        /// <summary>
        /// This is how the computer determines what card to play
        /// </summary>
        private void ComputerMove()
        {
            
            RiverLabel.Text = riverHand.ToString();
            int cardCount = 0;
            CardBox.CardBox newCardbox1 = new CardBox.CardBox();
            if (player2.IsAttacking && firstTurn)
            {
                for (int i = 0; i < player2.HandCount(); i++)
                {
                    newCardbox1.Card = player2.ChooseCardFromHand(i);
                    flowRiverHand.Controls.Add(newCardbox1);
                    riverHand.AddCardToHand(player2.ChooseCardFromHand(i));
                    flowComputersHand.Controls.RemoveAt(i);
                    player2.RemoveCardFromHand(player2.GetCard(i));
                    flowComputersHand.Controls.Remove(newCardbox1);
                    newCardbox1.FaceUp = true;
                    cardCount++;
                    firstTurn = false;
                    break;
                }
            }
            else if (player2.IsAttacking && !firstTurn)
            {
                for (int i = 0; i < player2.HandCount(); i++)
                {
                    if (riverHand.Ranks.Contains(player2.ChooseCardFromHand(i).Rank))
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
                    else
                    {
                        CardBox.CardBox newCardbox3 = new CardBox.CardBox();
                        while (riverHand.HandCount() > 0)
                        {
                            int l = 0;
                            CardBox.CardBox newCardbox2 = new CardBox.CardBox();
                            newCardbox2.Card = riverHand.GetCard(i);
                            flowComputersHand.Controls.Add(newCardbox2);
                            player2.AddCardToHand(riverHand.GetCard(i));
                            flowRiverHand.Controls.RemoveAt(i);
                            riverHand.RemoveCardFromHand(riverHand.GetCard(i));
                            flowRiverHand.Controls.Remove(newCardbox3);
                            flowComputersHand.Controls.Add(newCardbox2);
                            newCardbox2.Click += PlayerClickEvent;
                            newCardbox2.FaceUp = true;
                            l++;
                        }
                        if (player1.IsAttacking == false)
                        {
                            player1.IsAttacking = true;
                            player2.IsAttacking = false;
                            firstTurn = true;

                            lblAttack.Visible = true;
                            lblDefend.Visible = false;
                        }
                    }
                }
            }
            else if (!player2.IsAttacking)
            {
                for (int i = 0; i < player2.HandCount(); i++)
                {
                    // Defending
                    if (riverHand.HandCount() > 0)
                    {
                        if (player2.GetCard(i).Suit == trumpCard.GetCard(0).Suit && player2.GetCard(i).Suit > riverHand.GetCard(riverHand.HandCount() - 1).Suit ||
                            ((player2.GetCard(i).Suit == riverHand.GetCard(riverHand.HandCount() - 1).Suit) && player2.GetCard(i) > riverHand.GetCard(riverHand.HandCount() - 1)))
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
                firstTurn = true;
            }

            if (!player2.IsAttacking)
            {
                // If the player succeeds in an attack
                if (riverHand.HandCount() % 2 == 0)
                {
                    RiverLabel.Text = "Even";
                }
                else
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


        /// <summary>
        /// This is invoked when the player clicks a card and determines what to do with the card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                firstTurn = false;

                ComputerMove();
            }
            else if (player1.IsAttacking)
            {
                if (riverHand.Ranks.Contains(cardClicked.Rank))
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
            else if (!player1.IsAttacking)
            {
                if (riverHand.HandCount() > 0)
                {
                    if (cardClicked.Suit == trumpCard.GetCard(0).Suit && cardClicked > riverHand.GetCard(riverHand.HandCount() - 1) ||
                        ((cardClicked.Suit == riverHand.GetCard(riverHand.HandCount() - 1).Suit) && cardClicked > riverHand.GetCard(riverHand.HandCount() - 1)))
                    {
                        
                        lblTrumpCard.Text = "YOURE HERE";
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
                lblTrump.Text = trumpCard.ToString();

            }
            else if (riverHand.HandCount() % 2 == 0 && !player1.IsAttacking)
            {
                // If the player succeeds in an attack
                while (riverHand.HandCount() > 0)
                {
                    int i = 0;
                    CardBox.CardBox newCardbox2 = new CardBox.CardBox();
                    newCardbox2.Card = riverHand.GetCard(i);
                    flowPlayersHand.Controls.Add(newCardbox2);
                    player1.AddCardToHand(riverHand.GetCard(i));
                    flowRiverHand.Controls.RemoveAt(i + 1);
                    riverHand.RemoveCardFromHand(riverHand.GetCard(i));
                    flowRiverHand.Controls.Remove(cardBoxClicked);
                    newCardbox2.FaceUp = true;
                    i++;
                }

                //PickUpToSix(myDeck, player1, player2);
                SwapTurns();
            }

            RiverLabel.Text = riverHand.ToString();
            file.Write("\nCurrent Cards at the River Area " + riverHand.ToString() + "at " + today);
            PlayerLabel.Text = player1.ToString();
            file.Write("\nCurrent Cards at the Player Hand " + player1.ToString() + "at " + today);
            ComputerLabel.Text = player2.ToString();
            file.Write("\nCurrent Cards at the Computer Hand " + player2.ToString() + "at " + today);
            CardsRemainingLabel.Text = myDeck.DeckCount().ToString();

            CardsRemainingLabel.Text = "Cards Remaining: " + myDeck.DeckCount();
            file.Write("\nCards Remaining " + myDeck.DeckCount() + " at " + today);


        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (file == null)
            {
                file = new StreamWriter(userID + ".txt");
               
            }
            file.Write("Game started by " + userID + "at " + today);

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



            // Creating new player hands so the cards switch on reset
            player1 = new Player(player1Hand, true);
            player2 = new Player(player2Hand, false);

            firstTurn = true;

            if (rdo20Deck.Checked)
            {
                deckSize = 20;
            }
            else if(rdo36Deck.Checked)
            {
                deckSize = 36;
            }
            else if(rdo52Deck.Checked)
            {
                deckSize = 52;
            }

            // Create a new deck
            myDeck = new Deck(deckSize);

            myDeck.Shuffle();
            DealCards(player1, player2);
            GetTrumpCard();
            lblTrump.Text = trumpCard.ToString();
            flowRiverHand.Controls.Clear();

            // Visually showing the deck after start
            CardBox.CardBox DeckBack = new CardBox.CardBox();

            DeckBack.Card = myDeck.GetCard(0);
            DeckBack.FaceUp = false;
            DeckBack.Size = new Size(75, 107);
            flpDeck.Controls.Add(DeckBack);

            TurnChoice();

            if (player2.IsAttacking)
            {
                lblAttack.Visible = false;
                lblDefend.Visible = true;
                ComputerMove();
            }
            else
            {
                lblAttack.Visible = true;
                lblDefend.Visible = false;
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }


        


        private void btnTake_Click_1(object sender, EventArgs e)
        {
            CardBox.CardBox newCardbox1 = new CardBox.CardBox();
            while (riverHand.HandCount() > 0)
            {
                int i = 0;
                CardBox.CardBox newCardbox2 = new CardBox.CardBox();
                newCardbox2.Card = riverHand.GetCard(i);
                flowPlayersHand.Controls.Add(newCardbox2);
                player1.AddCardToHand(riverHand.GetCard(i));
                flowRiverHand.Controls.RemoveAt(i);
                riverHand.RemoveCardFromHand(riverHand.GetCard(i));
                flowRiverHand.Controls.Remove(newCardbox1);
                flowPlayersHand.Controls.Add(newCardbox2);
                newCardbox2.Click += PlayerClickEvent;
                newCardbox2.FaceUp = true;
                i++;
            }

            firstTurn = true;
            
            ComputerMove();
            PickUpToSix(myDeck, player1, player2);

            RiverLabel.Text = riverHand.ToString();
            PlayerLabel.Text = player1.ToString();
            ComputerLabel.Text = player2.ToString();

            CardsRemainingLabel.Text = "Cards Remaining: " + myDeck.DeckCount();

        }

        private void btnOkay_Click_1(object sender, EventArgs e)
        {

            // Clear controls (Visual Cards) from river
            flowRiverHand.Controls.Clear();

            // Remove cards from river logically & add last card removed as the top of discarded pile
            while (riverHand.HandCount() > 0)
            {
                riverHand.RemoveCardFromHand(riverHand.GetCard(0));

                if (riverHand.HandCount() == 1)
                {
                    // Putting Last card removed to display in the discard pile
                    CardBox.CardBox discardbox = new CardBox.CardBox();

                    discardbox.Card = riverHand.ChooseCardFromHand(0);
                    discardbox.FaceUp = true;
                    discardbox.Size = new Size(75, 107);
                    flpDiscarded.Controls.Add(discardbox);
                }
            }

            if (player1.IsAttacking)
            {
                btnOkay.Enabled = true;
            }

            SwapTurns();

            RiverLabel.Text = riverHand.ToString();
            PlayerLabel.Text = player1.ToString();
            ComputerLabel.Text = player2.ToString();

            CardsRemainingLabel.Text = "Cards Remaining: " + myDeck.DeckCount();
        }

        private void RiverLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://cardgameinfo.com/how-to-play-durak/%22");
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("C:\\Users\\Onur\\Desktop\\Durak\\DurakForm\\bin\\Debug");
        }
    }
}
