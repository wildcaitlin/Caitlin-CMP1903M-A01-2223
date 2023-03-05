using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            new Pack(); // Creates deck

            bool valid = false;
            while (!valid) {
                Console.Write("Shuffle type: ");
                string num = Console.ReadLine();
                // Converts input to integer or retries if a non integer is inputted
                try
                {
                    int shuffleType = Convert.ToInt32(num);
                    valid = Pack.shuffleCardPack(shuffleType); 
                } catch (FormatException) {
                    Console.WriteLine("Input an integer :(");
                }
                
            };

            int cards = 0;
            while (cards < 1 | cards > (Pack.pack.Count) ) // Makes sure input is in range of deck
            {
                Console.WriteLine("Deck size: " + Pack.pack.Count);
                Console.Write("Deal cards: ");
                string dealnum = Console.ReadLine();
                try
                {
                    cards = Convert.ToInt32(dealnum);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input an integer :(");
                }
            }

            // Calls method based on number of cards to be dealt
            if (cards == 1) {
                Pack.deal();
            }
            else
            {
                Pack.dealCard(cards);
            }
            

            Console.Read();
        }
    }
}
