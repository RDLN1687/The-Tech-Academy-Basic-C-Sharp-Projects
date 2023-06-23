using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace twentyOne
{
    public class Card
    {
        public string Suit { get; set; }
        public string Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

    }

    public enum Suit
    {
        Clubs,
        Diamond,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Ace,
        King,
        Queen,
        Jack
    }
}

