using System;
using System.Collections.Generic;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public Card[] CardDeck = new Card[52];
        public Pack()
        {
            //Initialise the card pack here
            int Count = 0;
            for (int SuitCount = 1; SuitCount < 5; SuitCount++)
            {
                for (int ValueCount = 1; ValueCount < 14; ValueCount++)
                {
                    CardDeck[Count] = new Card()
                    {
                        Value = ValueCount,
                        Suit = SuitCount
                    };
                    Count++;
                }
            }
        }
        
        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1)
            {
                this.CardDeck = FisherYatesShuffle();
            }
            else if (typeOfShuffle == 2)
            {
                this.CardDeck = RifleShuffle();
            }
            return true;
        }
        public Card deal()
        {
            //Deals one card
            Random rnd = new Random();
            int CardNumber = rnd.Next(51);
            return this.CardDeck[CardNumber];
        }
        public List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> MultipleCardDeal = new List<Card>();
            Random rnd = new Random();
            for (int i = 1; i <= amount; i++)
            {
                int CardNumber = rnd.Next(51);
                MultipleCardDeal.Add(this.CardDeck[CardNumber]);
            }
            return MultipleCardDeal;
        }
        public Card[] RifleShuffle()
        {
            int count = 0;
            int countOne = 0;
            Card[] FirstHalfDeck = new Card[26];
            Card[] SecondHalfDeck = new Card[26];
            Card[] FullShuffledDeck = new Card[52];
            for (int i = 0; i <= 25; i++)
            {
                FirstHalfDeck[i] = this.CardDeck[i];
            }
            for (int i = 26; i <= 51; i++)
            {
                SecondHalfDeck[count] = this.CardDeck[i];
                count++;
            }
            for (int i = 0; i <= 50; i = i + 2)
            {
                FullShuffledDeck[countOne] = FirstHalfDeck[countOne];
                FullShuffledDeck[countOne + 1] = SecondHalfDeck[countOne];
                countOne++;

            }
            Console.WriteLine("Successfully Shuffled!");
            return FullShuffledDeck;
        }
        public Card[] FisherYatesShuffle()
        {
            Card[] FullShuffledDeck = new Card[52];
            List<int> NumbersUsed = new List<int>();
            Random rnd = new Random();
            int CardNumber = 0;
            for (int i = 0; i < 51; i++)
            {
                bool NumChecked = false;
                int ListLen = 0;
                int match = 0;
                while (NumChecked == false)
                {
                    match = 0;
                    CardNumber = rnd.Next(51);
                    ListLen = NumbersUsed.Count;
                    for (int j = 0; j < ListLen; j++)
                    {
                        if (CardNumber == NumbersUsed[j])
                        {
                            match++;
                        }
                    }
                    if (match == 0)
                    {
                        NumChecked = true;
                    }
                }
                NumbersUsed.Add(CardNumber);
                FullShuffledDeck[i] = this.CardDeck[CardNumber];
            }
            Console.WriteLine("Successfully Shuffled!");
            return FullShuffledDeck;
        }
        
    }
}
