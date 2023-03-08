using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public int Suit { get; set; }

        public string NameCard()
        {
            string valuename;
            switch (Value)
            {
                case 1:
                    valuename = "Ace";
                    break;
                case 11:
                    valuename = "Jack";
                    break;
                case 12:
                    valuename = "Queen";
                    break;
                case 13:
                    valuename = "King";
                    break;
                default:
                    valuename = Value.ToString();
                    break;
            }

            string suitname;
            switch (Suit)
            {
                case 1:
                    suitname = "Hearts";
                    break;
                case 2:
                    suitname = "Diamonds";
                    break;
                case 3:
                    suitname = "Clubs";
                    break;
                case 4:
                    suitname = "Spades";
                    break;
                default:
                    suitname = "";
                    break;
            }

            return valuename + " of " + suitname;
        }
    }
}
