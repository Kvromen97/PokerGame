using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Project_b1c2
{
    class DrawCards
    {
        //draw cards outlines
        public static void DrawCardOutline(int xcoor, int ycoor)
        {
            Console.ForegroundColor = ConsoleColor.White;

            int x = xcoor * 12;
            int y = ycoor;

            Console.SetCursorPosition(x, y);
            Console.Write(" __________\n"); //top edge of card

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 9)
                    Console.WriteLine("|          |");//left and right edges of the card
                else
                    Console.WriteLine("|__________|");//bottom edge of the card
            }
        }

        //displays suit and value of the card
        public static void DrawCardSuitValue(Card card, int xcoor, int ycoor)
        {
            string cardSuit = " ";
            int x = xcoor * 12;
            int y = ycoor;

            //Encode each byte array from the CodePage437 into a character 
            //hearts and diamonds are red, clubs and spades are black
            switch (card.MySuit)
            {
                case Card.SUIT.HEARTS:
                    cardSuit = "\u2665"; // Hearts
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.SUIT.DIAMONDS:
                    cardSuit = "\u2666"; // Diamonds
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.SUIT.CLUBS:
                    cardSuit = "\u2663"; // Clubs
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.SUIT.SPADES:
                    cardSuit = "\u2660"; // Spades
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            //display the encoded character and value of the card
            Console.SetCursorPosition(x + 5, y + 5);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 4, y + 7);
            Console.Write(card.MyValue);


        }
    }
}

