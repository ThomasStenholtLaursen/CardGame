using CardGame.Card;
using CardGame.Interfaces;

namespace CardGame.Deck;

public class Deck : IDeck
{
    private readonly Random _rand = new();
    private readonly List<ICard> _cards = new();

    public void DealCards(List<IPlayer> players, int numberOfCardsToDeal)
    {
        var cards = GenerateDeck(100);

        foreach (var player in players)
        {
            for (var i = 0; i < numberOfCardsToDeal; i++)
            {
                var randomIndex = _rand.Next(0, cards.Count);

                player.ReceiveCard(cards[randomIndex]);
            }
        }
    }

    private List<ICard> GenerateDeck(int sizeOfDeck)
    {
        _cards.Clear();
        for (var i = 0; i < sizeOfDeck; i++)
        {
            _cards.Add(new Card.Card((CardType)RandomCardType(), RandomCardNumber()));
        }
        return _cards;
    }

    private int RandomCardNumber()
    {
        return _rand.Next(1, 9);  // creates a number between 1 and 8
    }

    private int RandomCardType()
    {
        return _rand.Next(1, Enum.GetValuesAsUnderlyingType<CardType>().Length + 1);  // creates a number between 1 and number of card types
    }

}