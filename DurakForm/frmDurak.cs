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

            // Add to computers hand
            CardBox.CardBox newCardbox = new CardBox.CardBox();
            
            newCardbox.Card = myDeck.DrawCard();
            newCardbox.FaceUp = true;
            flowComputersHand.Controls.Add(newCardbox);


            // Add to players han d
            CardBox.CardBox newCardbox1 = new CardBox.CardBox();

            newCardbox1.Card = myDeck.DrawCard();
            newCardbox1.FaceUp = true;
            flowPlayersHand.Controls.Add(newCardbox1);

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
   
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
