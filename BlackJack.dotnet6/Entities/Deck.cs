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
          for(var i=0;i<13;i++)
            {
                for(var j = 0; j < 4; j++)
                {
                    Card card= new Card();
                    card.Siut = (Suit)j;//casting j into Suit
                    card.Face = (Face)i;
                    Cards.Add(card);
                }
            }
        }

        public List<Card> Cards { get; set; } = new List<Card>() { };

        public void Shuffle (out int timesShuffled, int howManyTimes = 1 )
        {
            timesShuffled = 0;
            for (var i = 0; i < howManyTimes; i++)
            {

                List<Card> TempList = new List<Card>();
                Random random = new Random();
                timesShuffled++;

                for (var j = 0; j < 52; j++)
                {

                    var randomIndex = random.Next(0, Cards.Count);
                    var randomCard = Cards[randomIndex];

                    TempList.Add(randomCard);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
                
            }
           
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
