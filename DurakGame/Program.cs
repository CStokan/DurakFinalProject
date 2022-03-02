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

            Deck myDeck = new Deck(36);
            Player player1 = new Player();
            Player player2 = new Player();

            Console.WriteLine("Cards in Deck: " + myDeck.DeckCount());
            Console.WriteLine(myDeck.ToString());
            Console.WriteLine("Deal 6 cards to each player\n");

            Console.WriteLine(myDeck.DrawCards(6).ToString());

            // Mock deal 6 cards to 2 players
            for (int i = 0; i < 6; i++)
            {
                player1.AddCardToPlayer(myDeck.DrawCard());
                player2.AddCardToPlayer(myDeck.DrawCard());
            }            

            Console.WriteLine("Player 1");
            Console.WriteLine(player1.ToString());

            Console.WriteLine("Player 2");
            Console.WriteLine(player2.ToString());

            Console.WriteLine("\nCards in Deck: " + myDeck.DeckCount());

            Console.ReadKey();

        }
    }
}
