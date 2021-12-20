using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Project_b1c2
{
    class Deck
    {
        const int NUM_OF_CARDS = 52;
        private Card[] deck; //array of all playing cards
       
        public Deck()
        {
            deck = new Card[NUM_OF_CARDS];
        }

        public Card[] getDeck { get { return deck; } } //get current deck

        //create deck of 52 cards: 13 Values each, with 4 suits
        public void setUpDeck()
        {
           

            ShuffleCards();
        }
        //shuffle the deck
        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;

            //run the shuffle 1000 times
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < NUM_OF_CARDS; i++)
                {
                    //swap the cards
                    int secondCardIndex = rand.Next(13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }
    }
}
