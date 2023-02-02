using CardGameLib.Card;

namespace CardGameLib.Player;

public class Player : IPlayer
{
    private readonly string _playerName;
    private readonly PlayerType _playerType;
    public List<ICard> Cards { get; }

    public Player(string playerName, List<ICard> cards, PlayerType playerType)
    {
        _playerName = playerName;
        _playerType = playerType;
        Cards = cards;
    }

    public string GetPlayerName()
    {
        return _playerName;
    }

    public void ShowTotalHandValue()
    {
        var sum = GetTotalHandValue();
        Console.WriteLine($"{_playerName}: {sum}");
    }
    public int GetTotalHandValue()
    {
        return Cards.Sum(card => card.CalculateCardValue());
    }

    public void ShowHand()
    {
        Console.WriteLine($"{_playerName}:");
        foreach (var card in Cards)
        {
            Console.WriteLine($"{card.GetCardType()}({card.GetCardNumber()})");
        }
    }

    public void ReceiveCard(ICard card)
    {
        switch (_playerType)
        {
            case PlayerType.NormalPlayer:
                {
                    Cards.Add(card);
                    break;
                }
            case PlayerType.WeakPlayer:
                {
                    Cards.Add(card);

                    if (Cards.Count > 3)
                    {
                        Cards.RemoveAt(0);
                    }
                    break;
                }
            default:
                throw new ArgumentOutOfRangeException($"Invalid PlayerType");
        }
    }
}