using System;
using System.Collections.Generic;
namespace make_a_playing_card_deck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a collection that will act as a standard playing card deck that could be used for games. You need to be add items to it, take items out of it, and randomize it.
            List<Card> deck = new List<Card>();
           // A playing card deck has 52 cards in it, 4 suits, 13 cards per suit
           for (int i = 0; i < 52; i++)
            {
                // Prompt the user to Create the deck
                Console.WriteLine("Enter a suit: 1 for Hearts | 2 for Diamonds | 3 for Clubs | 4 for Spades");
                string suit = Console.ReadLine();
                if (suit == "1")
                {
                    suit = "Hearts";
                }
                else if (suit == "2")
                {
                    suit = "Diamonds";
                }
                else if (suit == "3")
                {
                    suit = "Clubs";
                }
                else
                {
                    suit = "Spades";
                }
                Console.WriteLine("Enter a value: 1-14. Please be mindful that you don't duplicate a value for a suit.");
                int value = Convert.ToInt32(Console.ReadLine());
                // Make an instance of the card class.
                Card card = new Card(suit, value);
                Console.WriteLine("Card: " + card.value + " of " + card.suit + " created.");
                // Add the card to the deck.
                deck.Add(card);
            }
        }
    }
}
