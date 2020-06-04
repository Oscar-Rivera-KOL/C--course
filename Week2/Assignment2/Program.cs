using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Dear User. Please be welome to our Game: Blackjack!!");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            deck.Print();
            Console.WriteLine();
            
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card Player1_1 = deck.TakeTopCard();
            Card Player2_1 = deck.TakeTopCard();
            Card Player3_1 = deck.TakeTopCard();
            Card Player1_2 = deck.TakeTopCard();
            Card Player2_2 = deck.TakeTopCard();
            Card Player3_2 = deck.TakeTopCard();

            // flip all the cards over
            Player1_1.FlipOver();
            Player2_1.FlipOver();
            Player3_1.FlipOver();
            Player1_2.FlipOver();
            Player2_2.FlipOver();
            Player3_2.FlipOver();

            // print the cards for player 1
            Console.WriteLine("The cards of the Player 1 are: ");
            Console.WriteLine("Card 1: " + Player1_1.Rank + " of "+ Player1_1.Suit);
            Console.WriteLine("Card 2: " + Player1_2.Rank + " of " + Player1_2.Suit);
            Console.WriteLine();
            // print the cards for player 2
            Console.WriteLine("The cards of the Player 2 are: ");
            Console.WriteLine("Card 1: " + Player2_1.Rank + " of "+ Player2_1.Suit);
            Console.WriteLine("Card 2: " + Player2_2.Rank + " of "+ Player2_2.Suit);
            Console.WriteLine();

            // print the cards for player 3
            Console.WriteLine("The cards of the Player 3 are: ");
            Console.WriteLine("Card 1: " + Player3_1.Rank + " of "+ Player3_1.Suit);
            Console.WriteLine("Card 2: " + Player3_2.Rank + " of "+ Player3_2.Suit);
            Console.WriteLine();


            Console.WriteLine();
        }
    }
}
