using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.dotnet6.Entities
{
    public abstract class Game
    {
        public List<Player> Players { get; set; } =new List<Player>();
        public string Name { get; set; } = default!;
        public Dealer dealer { get; set; } = default!;

        public abstract void printWelcomeMessage(string name);

        public abstract void Play();

        public virtual void ListPlayers()
        {
            string allPlayers = "PLAING TODAY: ";
            foreach (Player player in Players)
            {
                allPlayers = string.Concat(allPlayers,$"| {player.Name} |");
            };
            Console.WriteLine( allPlayers.ToString() );
        }
    }
}
