using GameLib.ClassLib;
using GameLib.Components;
namespace GameLib
{
    public class Core
    {
        private PlayerList playerList = new PlayerList();
        private List<Card> discardPile = new List<Card>();

        public List<Card> DiscardPile { get => discardPile;}
        public PlayerList PlayerList { get => playerList; }
    }
}