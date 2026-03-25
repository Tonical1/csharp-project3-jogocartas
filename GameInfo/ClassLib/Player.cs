using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInfo.ClassLib
{
    internal class Player
    {
        public string Name { get; }
        public List<Card> Deck { get; } = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }
    }
}
