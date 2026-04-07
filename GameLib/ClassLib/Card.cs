namespace GameLib.ClassLib
{
    public enum CardType
    {
        Nenhum,
        Ouros,
        Copas,
        Espadas,
        Paus,
        Coringa
    }

    public enum CardName
    {
        A, Dois, Tres, Quatro, Cinco, Seis, Sete, Oito, Nove, Dez, J, Q, K, Coringa
    }

    public class Card
    {
        public CardName Name { get; }
        public CardType Type { get; }

        public Card(CardName name, CardType type)
        {
            Name = name;
            Type = type;
        }

        public string Color()
        {
            if (Type == CardType.Copas || Type == CardType.Ouros)
                return "Vermelho";
            else if (Type == CardType.Espadas || Type == CardType.Paus)
                return "Preto";
            else
                return "Coringa";
        }

        public string Symbol()
        {
            switch (Type)
            {
                case CardType.Espadas: return "♠";
                case CardType.Paus: return "♣";
                case CardType.Ouros: return "♦";
                case CardType.Copas: return "♥";
                case CardType.Coringa: return "🃏";
                default: return "";
            }
        }
    }
}