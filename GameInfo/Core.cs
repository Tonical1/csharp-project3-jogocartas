using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Core
    {
        public List<string> Players = new List<string>();
        public void AddPlayer(string name)
        {
            if (Players.Count < MaxPlayers)
            {
                Players.Add(name);
            } else
            {
                Console.WriteLine("Numero de playerrs maximo");
            };
        }

        public List<string> CardTypes = new List<string>()
        {
            "Diamonds",
            "Hearts",
            "Spades",
            "Clubs",
        };

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
            { "JK", 0 }
        };

        public static int MinPlayers = 2;
        public static int MaxPlayers = 4;

        private int playerTurn = 1;
        public int PlayerTurn
        {
            get { return playerTurn; }
            set { playerTurn = Math.Clamp(value,1,Players.Count); }
        }

        public List<string> Deck { get; private set; } = new List<string>();
        public void BuildDeck()
        {

        }

        public void NextTurn()
        {
            PlayerTurn++;
            if (PlayerTurn > Players.Count) PlayerTurn = 1;
        }
    }
}
