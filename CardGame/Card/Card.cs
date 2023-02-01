using CardGame.Interfaces;

namespace CardGame.Card;

public class Card : ICard
{
    private readonly CardType _cardType;
    private readonly int _cardNumber;

    public Card(CardType cardType, int cardNumber)
    {
        _cardType = cardType;
        _cardNumber = cardNumber;
    }

    public int CalculateCardValue()
    {
        return (int)_cardType * _cardNumber;
    }

    public string? GetCardType()
    {
        return Convert.ToString(_cardType);
    }

    public string GetCardNumber()
    {
        return Convert.ToString(_cardNumber);
    }
}