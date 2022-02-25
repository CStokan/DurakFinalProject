using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardsLibrary;

namespace DurakGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Create a deck of 36 cards using the param constructor
            Deck myDeck = new Deck(36);
            // Equals work
            Console.WriteLine("Testing == operator for card {0} and card {1}", myDeck.GetCard(8).ToString(), myDeck.GetCard(8).ToString());
            Console.WriteLine(myDeck.GetCard(8) == myDeck.GetCard(8));

            // < than is working
            Console.WriteLine("Testing < operator for card {0} and card {1}", myDeck.GetCard(5).ToString(), myDeck.GetCard(7).ToString());
            Console.WriteLine(myDeck.GetCard(5) < myDeck.GetCard(7));

            // > than is 
            Console.WriteLine("Testing > operator for card {0} and card {1}", myDeck.GetCard(8).ToString(), myDeck.GetCard(7).ToString());
            Console.WriteLine(myDeck.GetCard(8) > myDeck.GetCard(7));

            // !=
            Console.WriteLine("Testing != operator for card {0} and card {1}", myDeck.GetCard(8).ToString(), myDeck.GetCard(7).ToString());
            Console.WriteLine(myDeck.GetCard(8) != myDeck.GetCard(7));

            // !=


            // Write deck count
            Console.WriteLine(myDeck.DeckCount());

            // Write deck to string
            myDeck.DeckToString(myDeck);

            Console.ReadKey();

        }
    }
}
