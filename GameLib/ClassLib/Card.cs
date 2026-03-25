namespace GameLib.ClassLib
{
    public class Card
    {

        public string Name { get; }
        public CardType Type { get; }

        public Card(string name, CardType type)
        {
            Name = name;
            Type = type;
        }
    }

    public enum CardType
    {
        Nenhum,
        Ouros,
        Copas,
        Espadas,
        Paus
    }
}