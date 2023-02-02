using CardGameLib.Deck;
using CardGameLib.Player;

namespace CardGameLib.Game
{
    public class GameController : IGameController
    {
        private readonly List<IPlayer> _players;
        private readonly IDeck _deck;
        private readonly GameType _gameType;

        public GameController(List<IPlayer> players, IDeck deck, GameType gameType)
        {
            _players = players;
            _deck = deck;
            _gameType = gameType;
        }

        public void CommandDealCards(int numberOfCardsToDeal)
        {
            _deck.DealCards(_players, numberOfCardsToDeal);
        }

        public void AnnonceWinner()
        {
            switch (_gameType)
            {
                case GameType.Max:
                {
                    var max = _players.Select(player => player.GetTotalHandValue()).ToList().Max();
                    var winner = _players.FirstOrDefault(x => x.GetTotalHandValue() >= max);

                    Console.WriteLine($"(Maximum GameController Variant) The winner is {winner!.GetPlayerName()} with a total of {winner!.GetTotalHandValue()} on hand");
                    break;
                }
                case GameType.Min:
                {
                    var min = _players.Select(player => player.GetTotalHandValue()).ToList().Min();
                    var winner = _players.FirstOrDefault(x => x.GetTotalHandValue() <= min);

                    Console.WriteLine($"(Minimum GameController Variant) The winner is {winner!.GetPlayerName()} with a total of {winner!.GetTotalHandValue()} on hand");
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException($"Invalid GameController Type");
            }
        }
    }
}
