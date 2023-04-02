﻿using BlackJack.dotnet6.Entities;

Deck deck = new Deck();
int timesShuffled = 0;
Deck.Shuffle(deck,out timesShuffled, 4);

foreach(Card card in deck.Cards)
{
    Console.WriteLine($"{card.Face} of {card.Siut}");
}
Console.WriteLine(deck.Cards.Count + ": Shuffled "+timesShuffled+" times");
Console.ReadLine();

