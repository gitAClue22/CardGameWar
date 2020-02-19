using System;
using System.Collections.Generic;

namespace CardDeck
{
    class Deck
    {
        Queue<Card> Cards { get; set; }
        public int NumCards { get => Cards.Count; }

        public Deck()
        {
            Cards = new Queue<Card>();
        }

        public void AddCard(Card newCard)
        {
            Cards.Add(newCard);
        }

        public Card RemoveTopCard()
        {
            Card cardToRemove = Cards[0];
            Cards.RemoveAt(0);
            return cardToRemove;
        }

        public void PrintDeck()
        {
            foreach (Card c in Cards)
            {
                System.Console.WriteLine(c);
            }
        }

     

        public void ShuffleDeck()

        {
            Random r = new Random();
            int firstCard = r.Next(52);
            int secondCard = r.Next(52);
            Card c = Cards[firstCard];
            Card b = Cards[secondCard];
            Cards[firstCard] = b;
            Cards[secondCard] = c;

            



        }
  
        

    }

        }


    
