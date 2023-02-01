namespace CardGame.Interfaces
{
    public interface IGame
    {
        void CommandDealCards(int numberOfCardsToDeal);
        void AnnonceWinner();
    }
}
