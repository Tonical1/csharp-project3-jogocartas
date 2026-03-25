using System;
using System.Collections.Generic;

namespace GameInfo.ClassLib
{
    internal static class CardValues
    {
        public static readonly Dictionary<string, int> List = new Dictionary<string, int>
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
    }
}