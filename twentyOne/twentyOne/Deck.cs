using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Spades", "Diamond" };
            List<string> Faces = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six",
                                                    "Seven", "Eight", "Nine", "Ten", "King", "Queen", "Jack"};

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }

        public List<Card> Cards { get; set; }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times)
        {
            timesShuffled = 3;
            for (int i = 0; i< times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }
    }
}
