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

            Deck myDeck = new Deck(52);

            Cards player1 = new Cards();


            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());
                if (i != 51)
                    Console.WriteLine();
                else
                    Console.WriteLine();
            }


            Console.ReadKey();



        }
    }
}
