namespace GameLib.ClassLib
{
    public class Card
    {

        private string name = "";
        private CardType type = 0;

        public string Name { get; }
        public CardType Type { get; }

        public Card(string pName, CardType pType)
        {
            name = pName;
            type = pType;
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