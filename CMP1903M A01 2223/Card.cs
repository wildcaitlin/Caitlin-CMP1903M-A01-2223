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

        private int _Value;
        public int Value
        {

            get { return _Value; }
            set
            {

                if ((value >= 1) && (value <= 13)) // Makes sure Value is between 1 and 13
                {
                    _Value = value;
                }

            }
        }

        private int _Suit;
        public int Suit {
            get { return _Suit; }
            set
            {
                if ((value >= 1) && (value <= 4)) // Makes sure Suit is between 1 and 4
                {
                    _Suit = value;
                }
            }
        }

        public string NameCard() // This assigns proper names to cards to make it more user friendly when cards are displayed
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
