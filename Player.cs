using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Player
    {
        // Field: List of card objects
        public List<Card> Hand;
        // Field: Player's name
        public string Name;

        // Constructor
        public Player(string givenName)
        {
            Hand = new List<Card>();
            Name = givenName;
        }

        // Draw: draw card from given deck and add it to hand
        public Card draw(Deck givenDeck)
        {
            Card drawnCard = givenDeck.deal();
            Hand.Add(drawnCard);
            return drawnCard;
        }
        // Discard: discard card at given index from player's hand, or null if idx does not exist
        public Card discard(int handIndex)
        {
            if (handIndex < 0 || Hand.Count <= handIndex) return null;
            Card disCard = Hand[handIndex];
            Hand.RemoveAt(handIndex);
            return disCard;
        }
        
    }
}