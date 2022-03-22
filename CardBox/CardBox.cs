using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardsLibrary;
/**
 * @Author : Cooper, Onur, Alex
 * 
 */
namespace CardBox
{
    public partial class CardBox: UserControl
    {
        #region Fields and Properties

        private Card myCard;
        /// <summary>
        /// Getter and setter
        /// </summary>
        public Card Card
        {
            set
            {
                myCard = value;
                UpdateCardImage();
            }

            get { return myCard; }
        }

        /// <summary>
        /// Getter and setter
        /// </summary>
        public SuitEnum Suit
        {
            set
            {
                Card.Suit = value;
                UpdateCardImage();
            }

            get { return Card.Suit; }
        }
        /// <summary>
        /// Getter and Setter
        /// </summary>
        public RankEnum Rank
        {
            set
            {
                Card.Rank = value;
                UpdateCardImage();
            }

            get { return Card.Rank; }
        }        
        
        /// <summary>
        /// Getter and Setter
        /// </summary>
        public bool FaceUp
        {
            set
            {
                // If value is different than the underlying cards faceup property
                if(myCard.FaceUp != value) // Then the card is flipping over
                {
                    myCard.FaceUp = value; // Change the cards faceup property

                    UpdateCardImage();

                    // If there is an event handler for Card Flipped in the client program
                    if(CardFlipped != null) 
                    {
                        CardFlipped(this, new EventArgs()); // Call it
                    }
                }
            }

            get { return Card.FaceUp; }
        }

        private Orientation myOrientation;
        public Orientation CardOrientation
        {
            set
            {
                // If value is different than my orientation
                if(myOrientation != value)
                {
                    // Change orientation
                    myOrientation = value;
                    // Swap the height and width of the control
                    this.Size = new Size(Size.Height, Size.Width);
                    // Update the card image
                    UpdateCardImage();
                }
            }

            get { return myOrientation; }
        }

        /// <summary>
        /// This is used to update the Picture box and will rotate if necessary
        /// </summary>
        private void UpdateCardImage()
        {
            // Set the image using the underlyingh card
            pbMyPictureBox.Image = myCard.GetCardImage();

            // If the orintation is horizontal
            if(myOrientation == Orientation.Horizontal)
            {
                // Rotate the image
                pbMyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }
        #endregion


        #region Constructors
        /// <summary>
        /// Constructor (Default)
        /// </summary>
        public CardBox()
        {
            InitializeComponent();
            myOrientation = Orientation.Vertical;
            myCard = new Card();
        }        
        
        /// <summary>
        /// Constructor (Param) - Takes a card that its passed
        /// </summary>
        public CardBox(Card card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();
            myOrientation = orientation;
            myCard = card;
        }
        #endregion


        #region EVENTS AND EVENT HANDLERS

        /// <summary>
        /// An event handler for the load event
        /// </summary>
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage();
        }

        /// <summary>
        /// An event the client program can handle when the user clicks the control
        /// </summary>
        new public event EventHandler Click;


        /// <summary>
        /// An event the client program can handle when the card flips face up/down
        /// </summary>
        new public event EventHandler CardFlipped;

        /// <summary>
        /// Handles when the user clicks the card
        /// </summary>
        private void pbMyPictureBox_Click(object sender, EventArgs e)
        {
            if(Click != null) // If there is a handler for clicking the control in the client program
            {
                Click(this, e); // Call it
            }
        }

        #endregion

        #region OTHER METHODS

        /// <summary>
        /// ToString: OVerrides ToString method
        /// </summary>
        /// <returns>myCard to String</returns>
        public override string ToString()
        {
            return myCard.ToString();
        }



        #endregion


    }
}
