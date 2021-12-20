using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Project_b1c2
{
    class DealCards : Deck
    {
        private Card[] playerHand;
        private Card[] computerHand;
        private Card[] sortedPlayerHand;
        private Card[] sortedComputerHand;

        public DealCards()
        {
            playerHand = new Card[5];
            sortedPlayerHand = new Card[5];
            computerHand = new Card[5];
            sortedComputerHand = new Card[5];
        }

        public void Deal()
        {
            setUpDeck(); //create the deck of cards and shuffle them
            getHand(); //dealers and players hand
            sortCards(); //sorting the cards
            displayCards(); //displaying the cards
            evaluateHands(); 
        }

        public void getHand()
        {


            // 5 cards for the players
            for (int i = 0; i < 5; i++)
                playerHand[i] = getDeck[i];

            // 5 cards for the computer
            for (int i = 5; i < 10; i++)
                computerHand[i - 5] = getDeck[i];


        }

        public void sortCards()
        {
            var queryPlayer = from hand in playerHand
                              select hand;

            var queryComputer = from hand in computerHand
                                select hand;




            var index = 0;
            foreach (var element in queryPlayer.ToList())
            {
                sortedPlayerHand[index] = element;
                index++;
            }

            index = 0;
            foreach (var element in queryComputer.ToList())
            {
                sortedComputerHand[index] = element;
                index++;

            }
        }
        public void displayCards()
        {
            Console.Clear();
            int x = 0; // x position of the cursor.
            int y = 1; // y position of the cursor.

            //display player hand
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("PLAYER'S HAND");
            for (int i = 0; i < 5; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(sortedPlayerHand[i], x, y);
                x++;
            }
            y = 15; // move the row of computer cards below the player's cards
            x = 0; // reset x position
            Console.SetCursorPosition(x, 14);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("COMPUTER'S HAND");
            for (int i = 5; i < 10; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(sortedComputerHand[i - 5], x, y);
                x++; // move to the right 
            }

        }
        public void evaluateHands()
        {
            HandEvaluator playerHandEvaluator = new HandEvaluator(sortedPlayerHand);
            HandEvaluator computerHandEvaluator = new HandEvaluator(sortedComputerHand);

            Hand playerHand = playerHandEvaluator.EvaluateHand();
            Hand computerHand = computerHandEvaluator.EvaluateHand();

            //display each hand
            Console.WriteLine("\n\n\n\n\nPlayer Hand: " + playerHand);
            Console.WriteLine("\nComputer Hand: " + computerHand);

            //evaluating the hands
            if (playerHand > computerHand)
            {
                Console.WriteLine("Player Wins!");
            }
            else if (playerHand < computerHand)
            {
                Console.WriteLine("Computer Wins!");
            }
            else //if the hands are the same, evaluate values
            {
                if (playerHandEvaluator.HandValues.Total > computerHandEvaluator.HandValues.Total)
                    Console.WriteLine("Player Wins!");
                else if (playerHandEvaluator.HandValues.Total < computerHandEvaluator.HandValues.Total)
                    Console.WriteLine("Computer Wins!");
                //Evaluating the same hand (Higher card wins)
                else if (playerHandEvaluator.HandValues.HighCard > computerHandEvaluator.HandValues.HighCard)
                    Console.WriteLine("Player Wins!");
                else if (playerHandEvaluator.HandValues.HighCard < computerHandEvaluator.HandValues.HighCard)
                    Console.WriteLine("Computer Wins!");
                else
                    Console.WriteLine("It's a draw!");


            }
        }
    }
}
