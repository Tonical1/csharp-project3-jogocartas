using System;
using Game;

namespace JogoDeCartas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Core game = new Core();
            game.Players.Add("Pedro");
            game.Players.Add("João");

            game.BuildDeck();

            foreach (var card in Core.CardValues)
            {
                Console.WriteLine($"a carta {card.Key} tem o valor de: {card.Value}");
            }
        }
    }
}