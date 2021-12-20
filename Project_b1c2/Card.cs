using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Project_b1c2
{
    class Card
    {
        public enum SUIT
        {
            CLUBS,
            DIAMONDS,
            SPADES,
            HEARTS
        }

        public enum VALUE
        {
            TWO = 2, THREE, FOUR, FIVE, SIX, SEVEN,
            EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
        }

        //properties
               
        public SUIT MySuit { get; set; }
        public VALUE MyValue { get; set; }

    }

}
