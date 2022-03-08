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


            Deck myDeck = new Deck(36);
            Player player1 = new Player();
            Player player2 = new Player();

            //// Mock deal 6 cards to 2 players
            //for (int i = 0; i < 6; i++)
            //{
            //    player1.AddCardToPlayer(myDeck.DrawCard());
            //    pbxCard.ImageLocation = "./Resources/c4.png";
            //    pbxCard.SizeMode = PictureBoxSizeMode.AutoSize;
            //    player2.AddCardToPlayer(myDeck.DrawCard());
            //}

            int test = 4;


            if (test == 4)
            {

              
            }
        }
    }
}
