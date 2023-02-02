using CardGameLib.Card;

namespace CardGameLib.Player
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
