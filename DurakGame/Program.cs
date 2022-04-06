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

            //Deck myDeck = new Deck(36);
            //Hand player1Hand = new Hand();
            //Hand player2Hand = new Hand();
            //
            //
            //Player player1 = new Player(player1Hand);
            //Player player2 = new Player(player2Hand);
            Deck myDeck = new Deck(36);
            Cards myCard = new Cards();

            Hand player1Hand = new Hand();
            Hand player2Hand = new Hand();

            Player player1 = new Player(player1Hand);
            Player player2 = new Player(player2Hand);


            Console.WriteLine("Cards in Deck: " + myDeck.DeckCount());
            Console.WriteLine(myDeck.ToString());
            Console.WriteLine("Deal 6 cards to each player\n");

            for (int i = 0; i <= 35; i++)
            {
                int card = 0;
                Console.WriteLine(myDeck.GetCard(card).ToString());
                Console.WriteLine(myDeck.DrawCard().GetHashCode());
                card++;
            } 



            Console.WriteLine("\nCards in Deck: " + myDeck.DeckCount());

            Console.ReadKey();

        }
    }
}
