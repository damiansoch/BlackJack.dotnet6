using BlackJack.dotnet6.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.dotnet6.Entities
{
    public class BlackJackGame : Game,IWalkAway
    {
        public override void printWelcomeMessage(string name)
        {
            Console.WriteLine($" \n Hello {name}! Welcome to the Black Jack game! \n");
        }
        public override void Play()
        {
            Console.WriteLine("playing...");
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Welcome to Black Jack Game");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
