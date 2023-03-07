using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{          
    class Testing
    {
        static void Main(string[] args)
        {
            Pack CardPackOne = new Pack();
            bool play = true;
            while (play == true)
            {
                Console.WriteLine("Shuffle(S) || Deal One card(D1) || Deal Multiple Cards(DM) || Quit(Q)");
                string Choice = (Console.ReadLine()).ToUpper();
                if (Choice == "S")
                {
                    Console.WriteLine("Fishers Yates Shuffle(F) || Riffle Shuffle(R)");
                    string ShuffleChoice = (Console.ReadLine()).ToUpper();
                    if (ShuffleChoice == "F")
                    {
                        CardPackOne.shuffleCardPack(1);
                    }
                    else if (ShuffleChoice == "R")
                    {
                        CardPackOne.shuffleCardPack(2);
                    }
                    else
                    {
                        Console.WriteLine("Not a valid choice");
                    }
                }
                else if (Choice == "D1")
                {
                    Card SingularCardDeal = CardPackOne.deal();
                    Console.WriteLine("Suit - " + SingularCardDeal.Suit + " Value - " + SingularCardDeal.Value);
                }
                else if (Choice == "DM")
                {
                    Console.WriteLine("Enter number of cards to deal");
                    int AmountToDeal = Convert.ToInt32(Console.ReadLine());
                    List<Card> MultipleCardDeal = CardPackOne.dealCard(AmountToDeal);
                    for (int i = 0; i < AmountToDeal; i++)
                    {
                        Console.WriteLine("Suit - " + MultipleCardDeal[i].Suit + " Value - " + MultipleCardDeal[i].Value);
                    }
                }
                else if (Choice == "Q")
                {
                    play = false;
                }
                else
                {

                }

            }
        }
    }
}
