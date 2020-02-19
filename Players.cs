using System;
using System.Collections.Generic;
using System.Text;

namespace CardDeck
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck { get; set; }

        public Player() { }

        public Player(string name)
        {
            Name = name;
        }

        public Queue<Card> Deal(Queue<Card> cards)
        {
            Queue<Card> player1cards = new Queue<Card>();
            Queue<Card> player2cards = new Queue<Card>();

          

            Deck = player1cards;
            return player2cards;
        }
    }
}
    
 
    

