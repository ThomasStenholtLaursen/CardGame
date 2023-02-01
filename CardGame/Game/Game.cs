using CardGame.Card;
using CardGame.Interfaces;

namespace CardGame.Game
{
    public class Game : IGame
    {
        private readonly List<IPlayer> _players;
        private readonly IDeck _deck;
        private readonly GameType _gameType;

        public Game(List<IPlayer> players, IDeck deck, GameType gameType)
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
                    var handValues = _players.Select(player => player.GetTotalHandValue()).ToList();
                    var max = handValues.Max();
                    var winner = _players.FirstOrDefault(x => x.GetTotalHandValue() >= max);

                    Console.WriteLine($"(Maximum Game Variant) The winner is {winner!.GetPlayerName()} with a total of {winner!.GetTotalHandValue()} on hand");
                    break;
                }
                case GameType.Min:
                {
                    var handValues = _players.Select(player => player.GetTotalHandValue()).ToList();
                    var min = handValues.Min();
                    var winner = _players.FirstOrDefault(x => x.GetTotalHandValue() <= min);

                    Console.WriteLine($"(Minimum Game Variant) The winner is {winner!.GetPlayerName()} with a total of {winner!.GetTotalHandValue()} on hand");
                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException($"Invalid Game Type");
            }
        }
    }
}
