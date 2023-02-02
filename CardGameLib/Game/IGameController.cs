namespace CardGameLib.Game
{
    public interface IGameController
    {
        void CommandDealCards(int numberOfCardsToDeal);
        void AnnonceWinner();
    }
}
