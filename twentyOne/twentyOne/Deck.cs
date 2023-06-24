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

            for (int i = 0; i <13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);

                 }
            }

            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Spades", "Diamond" };
            //List<string> Faces = new List<string>() { "Ace", "Two", "Three", "Four", "Five", "Six",
            //                                        "Seven", "Eight", "Nine", "Ten", "King", "Queen", "Jack"};

            //foreach (string face in Faces)
            //{
            //    //foreach (string suit in Suits)
            //    //{
            //    //    Card card = new Card();
            //    //    card.Suit = Suit;
            //    //    card.Face = Face;
            //    //    Cards.Add(card);
            //    //}
            //}
        }

        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            //timesShuffled = 3;
            for (int i = 0; i< times; i++)
            {
                //timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0,Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
          
        }
    }
}
