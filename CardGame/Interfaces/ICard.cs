namespace CardGame.Interfaces
{
    public interface ICard
    {
        int CalculateCardValue();   
        string? GetCardType();
        string GetCardNumber();
    }
}
