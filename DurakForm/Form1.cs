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


            Deck myDeck = new Deck(36);
            Player player1 = new Player();
            Player player2 = new Player();

            Random Randomsuit = new Random();
            Type Suittype = typeof(SuitEnum);
            Array Suitvalues = Suittype.GetEnumValues();
            int Suitindex = Randomsuit.Next(Suitvalues.Length);
            SuitEnum Suit = (SuitEnum)Suitvalues.GetValue(Suitindex);

            Random RandomRank = new Random();
            Type Ranktype = typeof(RankEnum);
            Array Rankvalues = Ranktype.GetEnumValues();
            int Rankindex = RandomRank.Next(Rankvalues.Length);
            RankEnum Rank = (RankEnum)Rankvalues.GetValue(Rankindex);

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;

            for (int i = 1; i <= 12; i++)
            {
               Image img = Image.FromFile("D:\\SCHOOL\\FIANL\\DurakForm\\Resources\\" + (Char)Suit + (int)Rank + ".png");

                Suittype = typeof(SuitEnum);
                Suitvalues = Suittype.GetEnumValues();
                Suitindex = Randomsuit.Next(Suitvalues.Length);
                Suit = (SuitEnum)Suitvalues.GetValue(Suitindex);

                Ranktype = typeof(RankEnum);
                Rankvalues = Ranktype.GetEnumValues();
                Rankindex = RandomRank.Next(Rankvalues.Length);
                Rank = (RankEnum)Rankvalues.GetValue(Rankindex);

                if (i == 1)
                {
                    pictureBox1.Image = img;
                }
                if (i == 2)
                {
                    pictureBox2.Image = img;
                }
                if (i == 3)
                {
                    pictureBox3.Image = img;
                }
                if (i == 4)
                {
                    pictureBox4.Image = img;
                }
                if (i == 5)
                {
                    pictureBox5.Image = img;
                }
                if (i == 6)
                {
                    pictureBox6.Image = img;
                }
                if (i == 7)
                {
                    pictureBox7.Image = img;
                }
                if (i == 8)
                {
                    pictureBox8.Image = img;
                }
                if (i == 9)
                {
                    pictureBox9.Image = img;
                }
                if (i == 10)
                {
                    pictureBox10.Image = img;
                }
                if (i == 11)
                {
                    pictureBox11.Image = img;
                }
                if (i == 12)
                {
                    pictureBox12.Image = img;
                }

            }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
