using GameLib.ClassLib;

namespace GameLib.Components
{
    public class PlayerList
    {
        private List<Player> playerList = new List<Player>();
        public IReadOnlyList<Player> GetPlayers() => playerList.AsReadOnly();

        public static int MinPlayers = 2;
        public static int MaxPlayers = 4;
        public bool AddPlayer(Player player)
        {
            if (!playerList.Exists(Target => Target.Name == player.Name) && playerList.Count<=MaxPlayers)
            {
                playerList.Add(player);
                return true;
            }
            return false;
        }

        public void RemovePlayer(string name)
        {
            playerList.RemoveAll(Target => Target.Name == name);
        }
    }
}