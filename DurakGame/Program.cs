using System;
using Cards.Domain.Standard;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurakGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create the deck
            var durakDeck = new Deck();
            var printDeck = new Deck();
            // Shuffle the deck to prevent same order
            Card player1 = new Card();
            Card player2 = new Card();
            Card player3 = new Card();
            Card player4 = new Card();

            // Give each player a card and print them accordingly
            // Need to find a way to allow the cards/player objects to hold a collection/array of cards ... Maybe new class ? (hand)
            for(int i = 0; i < 9; i++)
            {
                player1 = (Card)durakDeck.TakeCard();
                Console.WriteLine(player1.ToString());
                player2 = (Card)durakDeck.TakeCard();
                Console.WriteLine(player2.ToString());
                player3 = (Card)durakDeck.TakeCard();
                Console.WriteLine(player3.ToString());
                player4 = (Card)durakDeck.TakeCard();
                Console.WriteLine(player4.ToString());
            }

            Console.WriteLine("\n\n\nNEW SHUFFLED DECK\n\n\n");

            printDeck.Shuffle();
            printDeck.Reset();
            printDeck.Shuffle();

            // Print the whole durak deck
            foreach (Card c in printDeck.TakeCards(36))
            {
                Console.WriteLine(c.ToString());
            }

        }
    }
}
