namespace CardGameLib.Card
{
    public interface ICard
    {
        int CalculateCardValue();
        string? GetCardType();
        int GetCardNumber();
    }
}
