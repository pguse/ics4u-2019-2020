using System;
using System.Collections.Generic;

namespace War
{
    public class Deck
    {
        // Fields
        public List<Card> deck = new List<Card>();
        // Constructor
        public Deck()
        {
        }

        // Methods
        public void BuildDeck()
        {
            string[] suits = {"Spades","Clubs","Hearts","Diamonds"};

            foreach(string s in suits)
            {
                for(int v=1; v <= 13; v++)
                {
                    deck.Add( new Card(v,s) );
                }
            }

        }
        
        public int Size()
        {
            return this.deck.Count;
        }

        public void Add(Card c)
        {
            this.deck.Add(c);
        }

        public Card DealCard()
        {
            Card card = this.deck[0];
            this.deck.RemoveAt(0);
            return card;
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            for(var i=0; i < Size(); i++)
            {
                int n = rnd.Next(0,this.deck.Count);
                Card swap = this.deck[i];
                this.deck[i] = this.deck[n];
                this.deck[n] = swap;
            }
        }
    }    
}