using System;
using System.Collections.Generic;
using System.Text;

namespace make_a_playing_card_deck
{
    class Card
    {
        // Basic Card class with 2 properties, suit and value.
        // Create a constructor with 2 values being passed in.
        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
        public string suit { get; set; }
        public int value { get; set; }

    }

}
