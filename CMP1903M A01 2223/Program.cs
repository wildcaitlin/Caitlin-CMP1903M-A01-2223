using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            bool exit = false;

            while (!exit) // Makes the program loop until the user exits it
            {
                bool valid = false;
                Console.WriteLine("\n1: Shuffle\n2: Draw\n3: Exit");
                Console.Write("Your choice: ");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "1": // Does given shuffle type to deck
                        while (!valid)
                        {
                            Console.WriteLine("\n1: Fisher-Yates Shuffle\n2: Riffle Shuffle\n3: No shuffle");
                            Console.Write("Shuffle type: ");
                            string num = Console.ReadLine();
                            // Converts input to integer or retries if a non integer is inputted
                            try
                            {
                                int shuffleType = Convert.ToInt32(num);
                                valid = Pack.shuffleCardPack(shuffleType);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Input an integer :(");
                            }

                        };
                        break;

                    case "2": // Checks if deck is empty (can't draw) and draws given number of cards
                        if (Pack.pack.Count == 0) {
                            Console.WriteLine("\nDeck is empty.");
                            break;
                        }
                        int cards = 0;
                        while (cards < 1 | cards > (Pack.pack.Count)) // Makes sure input is in range of deck
                        {
                            Console.WriteLine("\nDeck size: " + Pack.pack.Count);
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
                        if (cards == 1)
                        {
                            Pack.deal();
                        }
                        else
                        {
                            Pack.dealCard(cards);
                        }
                    break; 

                        case "3": // Exits program
                        Console.WriteLine("Exiting program.");
                        return;

                }
            }
            }
        }
    }
