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
        private Random _random;
        public frmDurakGame()
        {
            InitializeComponent();

            _random = new Random();
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


            cbxTestCard.FaceUp = !cbxTestCard.FaceUp;


        }

        private void cbxTestCard_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxTestCard_Load(object sender, EventArgs e)
        {

        }

        private void cbxTestCard_Click_1(object sender, EventArgs e)
        {
            label1.Text = cbxTestCard.ToString() + " was clicked last.";

            if (cbxTestCard.CardOrientation == Orientation.Horizontal)
            {
                cbxTestCard.CardOrientation = Orientation.Vertical;
            }
            else
            {
                cbxTestCard.CardOrientation = Orientation.Horizontal;
            }
        }

        private void frmDurakGame_Load(object sender, EventArgs e)
        {
            Card theCard = new Card(SuitEnum.Diamonds, RankEnum.Seven);
            theCard.FaceUp = true;
            Deck myDeck = new Deck(36);

            this.cbxTestCard.Card = myDeck.DrawCard();

            
            
        }
    }
}
