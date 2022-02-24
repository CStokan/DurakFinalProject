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

            // Write deck count
            Console.WriteLine(myDeck.DeckCount());

            // Write deck to string
            myDeck.DeckToString(myDeck);

            Console.ReadKey();

        }
    }
}
