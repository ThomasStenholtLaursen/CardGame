using CardGameLib.Player;

namespace CardGameLib.Deck
{
    public interface IDeck
    {
        void DealCards(List<IPlayer> players, int numberOfCardsToDeal);
    }
}
