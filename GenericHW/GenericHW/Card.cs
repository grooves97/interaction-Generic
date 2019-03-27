using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHW
{
    public enum CardTypes
    {
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public enum CardSuits
    {
        Diamonds,
        Hearts,
        Spades,
        Clubs
    }

    public class Card
    {
        public CardTypes CardTypes { get; set; }
        public CardSuits CardSuits { get; set; }
    }
}
