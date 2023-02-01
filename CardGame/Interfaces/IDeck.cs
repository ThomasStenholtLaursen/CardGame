namespace CardGame.Interfaces
{
    public interface IDeck
    {
        void DealCards(List<IPlayer> players, int numberOfCardsToDeal);
    }
}
