using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void main(string[] args)
        {
            new Pack(); // Creates a Pack object
            // Calls the shuffleCardPack method with the different shuffle types
            Pack.shuffleCardPack(1);
            // Calls the deal methods
            Pack.deal();
            Pack.dealCard(51); // These also check what is returned (full deck to check shuffle)

            new Pack();
            Pack.shuffleCardPack(2);
            Pack.deal();
            Pack.dealCard(51);

            new Pack();
            Pack.shuffleCardPack(3);
            Pack.deal();
            Pack.dealCard(51);

            Console.Read();
        }
    }
}
