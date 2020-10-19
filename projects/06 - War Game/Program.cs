using System;
using System.Collections.Generic;

namespace War
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the Initial Deck
            Deck D = new Deck();
            D.BuildDeck();
            D.Shuffle();
            // Create Two Players
            Deck P1 = new Deck();
            Deck P2 = new Deck();
            // Deal the Cards to the Players
            // Notice the use of the Size() and Add()
            // methods from the Deck class
            while (D.Size() > 1)
            {
                P1.Add(D.DealCard());
                P2.Add(D.DealCard());
            }

            // Dealt Cards
            Card C1;
            Card C2;
            // Game Loop (5 rounds for now)
            for(var i=0; i < 5; i++)
            {
                C1 = P1.DealCard();
                C2 = P2.DealCard();
                Console.Write("{0} --- {1} ---",C1.Value,C2.Value);

                if (C1.Value > C2.Value)
                {
                    Console.WriteLine("P1 Wins!");
                    //Add Cards to P1
                }
                else if (C1.Value < C2.Value)
                {
                    Console.WriteLine("P2 Wins!");
                    //Add Cards to P2
                }
                else
                {
                    Console.WriteLine("War!");
                    List<Card> Temp = new List<Card>();
                    //Add Cards to Temp List
                    //Go to War
                    //Add All Cards from Temp to Winner and Clear Temp
                }
                // Wait for User Key Press
                Console.ReadKey();
            }
        }

    
    }
}
