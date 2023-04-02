using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.dotnet6.Entities
{
    public struct Card
    {
        
        public Card() { }

        public Suit Siut { get; set; } = default!;
        public Face Face { get; set; } = default!;
    }




    public enum Suit
    {
        Clubs,
        Diamonds,
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
        Feven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
