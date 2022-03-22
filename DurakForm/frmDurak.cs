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
        public frmDurakGame()
        {
            InitializeComponent();

            
        }

        public void DisplayCards()
        {
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }






        private void btnStart_Click(object sender, EventArgs e)
        {


            


            

        }

        private void cbxTestCard_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxTestCard_Load(object sender, EventArgs e)
        {

        }

        private void cbxTestCard_Click_1(object sender, EventArgs e)
        {

        }

        private void frmDurakGame_Load(object sender, EventArgs e)
        {
            Card theCard = new Card(SuitEnum.Diamonds, RankEnum.Seven);
            theCard.FaceUp = true;
            Deck myDeck = new Deck(36);


            CardBox.CardBox newCardBox = new CardBox.CardBox();
            CardBox.CardBox newCardBox1 = new CardBox.CardBox();
            CardBox.CardBox newCardBox2 = new CardBox.CardBox();
            CardBox.CardBox newCardBox3 = new CardBox.CardBox();
            CardBox.CardBox newCardBox4 = new CardBox.CardBox();
            CardBox.CardBox newCardBox5 = new CardBox.CardBox();
            CardBox.CardBox newCardBox6 = new CardBox.CardBox();

            newCardBox.Card = myDeck.DrawCard();
            newCardBox2.Card = myDeck.DrawCard();
            newCardBox1.Card = myDeck.DrawCard();
            newCardBox3.Card = myDeck.DrawCard();
            newCardBox5.Card = myDeck.DrawCard();
            newCardBox4.Card = myDeck.DrawCard();


            newCardBox.FaceUp = true;
            newCardBox2.FaceUp = true;
            newCardBox1.FaceUp = true;
            newCardBox3.FaceUp = true;
            newCardBox5.FaceUp = true;
            newCardBox4.FaceUp = true;
            newCardBox6.FaceUp = true;

            flowPlayersHand.Controls.Add(newCardBox);
            flowPlayersHand.Controls.Add(newCardBox2);
            flowPlayersHand.Controls.Add(newCardBox1);
            flowPlayersHand.Controls.Add(newCardBox3);
            flowPlayersHand.Controls.Add(newCardBox5);
            flowPlayersHand.Controls.Add(newCardBox4);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
