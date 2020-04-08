using System;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck bicycle = new Deck();
            bicycle.shuffle();
            Player neil = new Player("Neil");

            Console.WriteLine("First 3 of the Deck:");
            Console.WriteLine($"\t{bicycle.cards[0].StringVal} of {bicycle.cards[0].Suit}");
            Console.WriteLine($"\t{bicycle.cards[1].StringVal} of {bicycle.cards[1].Suit}");
            Console.WriteLine($"\t{bicycle.cards[2].StringVal} of {bicycle.cards[2].Suit}");
            Console.WriteLine("Neil's hand:");
            foreach (var card in neil.Hand)
            {
                Console.WriteLine($"\t{card.StringVal} of {card.Suit}");
            }

            // Testing Player.draw()
            Console.WriteLine($"\n{neil.Name} draws 2 cards.\n");
            neil.draw(bicycle);
            neil.draw(bicycle);
            Console.WriteLine("First 3 of the Deck:");
            Console.WriteLine($"\t{bicycle.cards[0].StringVal} of {bicycle.cards[0].Suit}");
            Console.WriteLine($"\t{bicycle.cards[1].StringVal} of {bicycle.cards[1].Suit}");
            Console.WriteLine($"\t{bicycle.cards[2].StringVal} of {bicycle.cards[2].Suit}");
            Console.WriteLine("Neil's hand:");
            foreach (var card in neil.Hand)
            {
                Console.WriteLine($"\t{card.StringVal} of {card.Suit}");
            }

            // Testing Player.discard()
            Console.WriteLine($"\n{neil.Name} discards 1 card.\n");
            neil.discard(2); // returns null and does nothing
            neil.discard(1); // removes card from hand[1]
            Console.WriteLine("First 3 of the Deck:");
            Console.WriteLine($"\t{bicycle.cards[0].StringVal} of {bicycle.cards[0].Suit}");
            Console.WriteLine($"\t{bicycle.cards[1].StringVal} of {bicycle.cards[1].Suit}");
            Console.WriteLine($"\t{bicycle.cards[2].StringVal} of {bicycle.cards[2].Suit}");
            Console.WriteLine("Neil's hand:");
            foreach (var card in neil.Hand)
            {
                Console.WriteLine($"\t{card.StringVal} of {card.Suit}");
            }



        }
    }
}
