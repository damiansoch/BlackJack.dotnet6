using BlackJack.dotnet6.Entities;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, What is your name?");

string name = Console.ReadLine();

while (name == "" )
{
    Console.WriteLine("Please, type in your name!");
    name= Console.ReadLine();
}

Console.WriteLine("Would you like to play?");
Console.WriteLine("Answer y or n");

string answer = Console.ReadLine();
while (answer != "y" && answer != "n")
{
    Console.WriteLine("Answer y or n");
    answer= Console.ReadLine();
}

if (answer == "n")
{
    Console.WriteLine("Thanks, Goodbye.");
}
else
{
    Player player = new Player() { Name = name, Balance = 1000, isActivelyPlaying = true };
    BlackJackGame game = new BlackJackGame();
    game .Players.Add(player);

    game.printWelcomeMessage(name);
    game.Play();
}
