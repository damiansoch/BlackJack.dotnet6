using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.dotnet6.Entities
{
    public class Player
    {
        public List<Card>? Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; } = default!;
        public bool isActivelyPlaying { get; set; }

        //overloading operator
        public static Game operator+ (Game game,Player player)
        {
            game.Players.Add (player);
            return game;
        }
        public static Game operator- (Game game,Player player)
        {
            game.Players.Remove (player);
            return game;
        }
    }
}
