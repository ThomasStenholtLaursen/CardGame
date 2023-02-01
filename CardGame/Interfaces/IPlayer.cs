namespace CardGame.Interfaces
{
    public interface IPlayer
    {
        string GetPlayerName();
        void ShowTotalHandValue();
        int GetTotalHandValue();
        void ShowHand();
        void ReceiveCard(ICard card);
    }
}
