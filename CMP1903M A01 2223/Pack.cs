using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            for (int i = 1; i <= 52; i++) {
                int v = 0;
                int s = 0;
                if (i % 13 == 0) // Stops some values being 0 + suits being -1 of the correct suit
                {
                    v = 13;
                    s = i / 13;
                }
              else
                {
                    v = i % 13;
                    s = (i / 13) + 1;
                }
                pack.Add(new Card() // Adds value and suit to list (deck)
                {
                    Value = (v),
                    Suit = (s),

            });
            }
            Console.WriteLine("Pack created!");

        }

        public List<Card> NameCard()
        {
            return pack;
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1) // fisher-yates shuffle
            {
                Console.WriteLine("Fisher-Yates Shuffle");
                // Swaps list items with random other item before itself starting from back of the deck
                // (from the wikipedia page)
                for (int i = (pack.Count - 1); (i > 1); i--) {
                    int j = new Random().Next(0, i);
                    Card temp = pack[j];
                    pack[j] = pack[i];
                    pack[i] = temp;
                }

                return true;
            }
            else if (typeOfShuffle == 2) // riffle shuffle;
            {
                Console.WriteLine("Riffle Shuffle");
                List<Card> list1 = new List<Card>();
                List<Card> list2 = new List<Card>();
                for (int i = 0; (i < pack.Count); i++) // 2 separate piles
                {
                    if (i < 26)
                    {
                        list1.Add(pack[i]); 
                    }
                    else
                    {
                        list2.Add(pack[i]);  
                    }
                }
                pack.Clear(); // Alternate adding the cards back to the pack like riffle shuffle
                for (int i = 0; (i < list1.Count); i++)
                {
                    pack.Add(list1[i]);
                    if (i < list2.Count)
                    {
                        pack.Add(list2[i]);
                    }
                    
                }

                    return true;
            }
            else if (typeOfShuffle == 3) // no shuffle
            {
                Console.WriteLine("No shuffle");
                return true;
            }
            Console.WriteLine("Invalid input (1-3)");
            return false; // Makes program ask for another input if its not an option
        }

        public static Card deal()
        {

            //Deals one card
            Card dealt = pack[0];
            pack.RemoveAt(0);
            Console.WriteLine("Dealt: " + dealt.NameCard());
            Console.WriteLine("Dealt 1 card!");
            return dealt;
           
            // Both deal types just deal first value (repeats for multiple)
            // The cards are removed so multiple draws could be looped if needed
        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> dealt = new List<Card>();
            for (int i = 0; i < amount; i++) {
                dealt.Add(pack[0]);
                pack.RemoveAt(0);
                Console.WriteLine("Dealt: " + dealt[i].NameCard());
            }

            Console.WriteLine("Dealt " + amount + " cards!");
            return dealt;

        }

    }
}
