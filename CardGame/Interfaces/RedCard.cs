namespace CardGame.Interfaces
{
    public class RedCard : ICard
    {
        private const int Multiplier = 1;

        public double CalculateCardValue(int cardValue)
        {
            return cardValue * Multiplier;
        }
    }
}
