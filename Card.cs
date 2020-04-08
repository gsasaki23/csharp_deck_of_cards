namespace Deck_of_Cards
{
    public class Card
    {
        // Fields
        public string Suit;
        // Suit: from Clubs, Spades, Hearts, Diamonds
        public string StringVal;
        // Value: Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King
        public int Val;
        // Point Value: from 1-13

        // Constructor
        public Card(string givenSuit, string givenStringVal, int givenVal)
        {
            Suit = givenSuit;
            StringVal = givenStringVal;
            Val = givenVal;
        }
    }
}