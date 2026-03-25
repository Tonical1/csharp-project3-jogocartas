using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInfo.ClassLib
{
    internal class Card
    {
        public string Value { get; }
        public CardType Type { get; }

        public Card(string value, CardType type)
        {
            Value = value;
            Type = type;
        }
    }
}
