using CardGame.Interfaces;

namespace CardGame.Player;

public class Player : IPlayer
{
    private readonly string _name;
    private readonly PlayerType _playerType;
    public List<ICard> Cards { get; }

    public Player(string name, List<ICard> cards, PlayerType playerType)
    {
        _name = name;
        _playerType = playerType;
        Cards = cards;
    }

    public string GetPlayerName()
    {
        return _name;
    }

    public void ShowTotalHandValue()
    {
        var sum = GetTotalHandValue();
        Console.WriteLine($"{_name}: {sum}");
    }
    public int GetTotalHandValue()
    {
        return Cards.Sum(card => card.CalculateCardValue());
    }

    public void ShowHand()
    {
        Console.WriteLine($"{_name}:");
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