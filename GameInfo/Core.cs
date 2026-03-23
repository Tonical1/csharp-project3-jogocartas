using System;
using System.Collections.Generic;

namespace Game
{
    public enum CardType
    {
        Ouros,
        Copas,
        Espadas,
        Paus
    }

    public class Card
    {
        public string Valor { get; set; }
        public CardType Naipe { get; set; }
    }

    public class Core
    {
        public static int MinPlayers = 2;
        public static int MaxPlayers = 4;

        public List<string> Players = new List<string>();

        public List<Card> Deck = new List<Card>();
        public void BuildDeck() { 
                
        }

        public Dictionary<string, List<Card>> Hands = new Dictionary<string, List<Card>>();

        public List<Card> DiscardPile = new List<Card>();

        public static Dictionary<string, int> CardValues = new Dictionary<string, int>
        {
            { "A", 1 },
            { "2", 2 },
            { "3", 3 },
            { "4", 4 },
            { "5", 5 },
            { "6", 6 },
            { "7", 7 },
            { "8", 8 },
            { "9", 9 },
            { "10", 10 },
            { "J", 11 },
            { "Q", 12 },
            { "K", 13 },
            { "Coringa", 0 }
        };

        private int playerTurn = 1;
        public int PlayerTurn
        {
            get => playerTurn;
            set => playerTurn = value;
        }
        public void NextTurn() {
            PlayerTurn++;
            if (PlayerTurn > Players.Count) PlayerTurn = 1; 
        }
    }
}