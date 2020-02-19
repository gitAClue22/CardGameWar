using System;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)



        {
            MainMenu();


            Deck d = new Deck();

            foreach (CardSuit cs in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue cv in Enum.GetValues(typeof(CardValue)))
                {
                    d.AddCard(new Card(cs, cv));
                }
            }

            d.PrintDeck();
            System.Console.WriteLine($"The number of cards in deck is {d.NumCards}");
          

            while (d.NumCards > 0)
            {
                System.Console.WriteLine(d.RemoveTopCard());
            }

            Card c1 = new Card(CardSuit.Clubs, CardValue.Five);
            Card c2 = new Card(CardSuit.Clubs, CardValue.Ten);
            Card c3 = new Card(CardSuit.Hearts, CardValue.Five);
/*
            Console.WriteLine($"Is {c1} > {c2}: {c1 > c2}");
            Console.WriteLine($"Is {c1} < {c2}: {c1 < c2}");
            Console.WriteLine($"Is {c1} >= {c2}: {c1 >= c2}");
            Console.WriteLine($"Is {c1} <= {c2}: {c1 <= c2}");
            Console.WriteLine($"Is {c1} == {c2}: {c1 == c2}");
            Console.WriteLine($"Is {c1} != {c2}: {c1 != c2}");

            Console.WriteLine($"Is {c1} > {c3}: {c1 > c3}");
            Console.WriteLine($"Is {c1} < {c3}: {c1 < c3}");
            Console.WriteLine($"Is {c1} >= {c3}: {c1 >= c3}");
            Console.WriteLine($"Is {c1} <= {c3}: {c1 <= c3}");
            Console.WriteLine($"Is {c1} == {c3}: {c1 == c3}");
            Console.WriteLine($"Is {c1} != {c3}: {c1 != c3}");
            */


        }

        static void MainMenu()
        {
            Deck d = new Deck();

            foreach (CardSuit cs in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue cv in Enum.GetValues(typeof(CardValue)))
                {
                    d.AddCard(new Card(cs, cv));
                }
            }

            int userInput = 0;
            while (userInput != -1)

            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("To Shuffle Deck, Enter 1");
                Console.WriteLine("To Add Card, Enter 2");
                Console.WriteLine("To Remove Card, Enter 3");
                Console.WriteLine("To Print Deck, Enter 4");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case -1:
                        break;
                    case 1:
                    case 2: 
                        

                    case 4:
                        d.PrintDeck();
                        break;





                }
                
            }
        }
    }
}
