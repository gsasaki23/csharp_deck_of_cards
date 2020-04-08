using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Deck
    {
        // Field: List of card objects
        public List<Card> cards;

        // Constructor: Adds 52 unique cards
        public Deck()
        {    
            reset();
        }

        // Deal: Remove and return "top-most" card
        public Card deal()
        {
            Card temp = cards[0];
            cards.RemoveAt(0);
            return temp;
        }

        // Reset: Reset cards with 52 unique cards
        public void reset()
        {
            cards = new List<Card>();      
            
            for (int i = 1; i <= 4; i++)
            {
                string suit;
                if (i == 1) suit = "Clubs";
                else if (i == 2) suit = "Diamonds";
                else if (i == 3) suit = "Spades";
                else suit = "Hearts";

                for (int j = 1; j <= 13; j++)
                {
                    string stringVal;
                    if (j == 1) stringVal = "Ace";
                    else if (j == 11) stringVal = "Jack";
                    else if (j == 12) stringVal = "Queen";
                    else if (j == 13) stringVal = "King";
                    else stringVal = j.ToString();

                    Card cardToAdd = new Card(suit,stringVal,j);
                    cards.Add(cardToAdd);
                }
            }
        }

        // Shuffle: Randomly reorder cards (Approach: swap 2 random indexes many times)
        public void shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count * 69; i++)
            {
                int a = rand.Next(0,cards.Count);
                int b = rand.Next(0,cards.Count);

                Card temp = cards[a];
                cards[a] = cards[b];
                cards[b] = temp;
            }
        }
    }
}