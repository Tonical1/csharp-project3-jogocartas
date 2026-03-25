using GameInfo.ClassLib;
using System;
using System.Collections.Generic;

namespace GameInfo
{
    internal class PlayerManager
    {
        private List<Player> PlayerList = new List<Player>();
        public IReadOnlyList<Player> GetPlayers() => PlayerList.AsReadOnly();

        private static int MinPlayers = 2;
        private static int MaxPlayers = 4;
        public bool AddPlayer(Player player)
        {
            if (!PlayerList.Exists(Target => Target.Name == player.Name))
            {
                PlayerList.Add(player);
                return true;
            }
            return false;
        }

        public void RemovePlayer(string name)
        {
            PlayerList.RemoveAll(Target => Target.Name == name);
        }
    }
}