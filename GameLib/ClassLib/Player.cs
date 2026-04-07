namespace GameLib.ClassLib
{
    public class Player
    {
        public string Name { get; }
        public List<Card> Deck { get; } = [];

        public Player(string name)
        {
            Name = name;
        }
    }
}
