using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.dotnet6.Entities
{
    public class Deck
    {

        public Deck()
        {
            List<string> Suits= new List<string>()
            {
                "Clubs","Hearts","Diamond","Spades"
            };
            List<string> Faces = new List<string>()
            {
                "Two","Three","Four","Fife","Six","Seven","Eight","Nine","Ten","Jack","Queen","King","Ace"
            };

            foreach(string face in Faces)
            {
                foreach(string suit in Suits)
                {

                    Card card = new Card();
                    card.Face = face;
                    card.Siut= suit;
                    Cards.Add(card);
                }
            }
        }

        public List<Card> Cards { get; set; } = new List<Card>() { };

        public static Deck Shuffle (Deck deck ,out int timesShuffled, int howManyTimes = 1 )
        {
            timesShuffled = 0;
            for (var i = 0; i < howManyTimes; i++)
            {

                List<Card> TempList = new List<Card>();
                Random random = new Random();
                timesShuffled++;

                for (var j = 0; j < 52; j++)
                {

                    var randomIndex = random.Next(0, deck.Cards.Count);
                    var randomCard = deck.Cards[randomIndex];

                    TempList.Add(randomCard);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
                
            }
           return deck;
        }

        ///OVERLOADNIG NOT NEEDED , BECAUSE OF CREATING OPTIONAL PARAMETERS IN THIS CASE
        //public static Deck Shuffle(Deck deck, int howManyTimes)
        //{
        //    for (var i = 0; i < howManyTimes; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
