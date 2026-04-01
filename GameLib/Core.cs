using GameLib.ClassLib;
using GameLib.Components;
namespace GameLib
{
    public class Core
    {
        private PlayerList playerList = new PlayerList();
        private List<Card> discardPile = [];

        public List<Card> DiscardPile { get => discardPile; }
        public PlayerList PlayerList { get => playerList; }
    }
}