using GameLib.ClassLib;

namespace GameLib.Components
{
    public class PlayerList
    {
        private List<Player> GameLibList = new List<Player>();
        public IReadOnlyList<Player> GetPlayers() => GameLibList.AsReadOnly();

        private static int MinPlayers = 2;
        private static int MaxPlayers = 4;
        public bool AddPlayer(Player player)
        {
            if (!GameLibList.Exists(Target => Target.Name == player.Name))
            {
                GameLibList.Add(player);
                return true;
            }
            return false;
        }

        public void RemovePlayer(string name)
        {
            GameLibList.RemoveAll(Target => Target.Name == name);
        }
    }
}