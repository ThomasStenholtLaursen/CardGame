using CardGame.Card;
using CardGame.Deck;
using CardGame.Game;
using CardGame.Interfaces;
using CardGame.Player;

var deck = new Deck();

Console.Write("Please enter the name of Player 1: ");
var player1Name = Console.ReadLine();
Console.Clear();
Console.Write("Please enter the name of Player 2: ");
var player2Name = Console.ReadLine();
Console.Clear();
Console.Write("Please enter the name of Player 3: ");
var player3Name = Console.ReadLine();
Console.Clear();
Console.Write("Please enter the name of Player 4 (Weak Player): ");
var player4Name = Console.ReadLine();
Console.Clear();

var player1 = new Player(player1Name!, new List<ICard>(), PlayerType.NormalPlayer);
var player2 = new Player(player2Name!, new List<ICard>(), PlayerType.NormalPlayer);
var player3 = new Player(player3Name!, new List<ICard>(), PlayerType.NormalPlayer);
var player4 = new Player(player4Name!, new List<ICard>(), PlayerType.WeakPlayer);


var listOfPlayers = new List<IPlayer>
{
    player1,
    player2,
    player3,
    player4
};

var game = new Game(listOfPlayers, deck, GameType.Min);
game.CommandDealCards(10);

player1.ShowHand();
Console.WriteLine();

player2.ShowHand();
Console.WriteLine();

player3.ShowHand();
Console.WriteLine();

player4.ShowHand();
Console.WriteLine();

player1.ShowTotalHandValue();
Console.WriteLine();

player2.ShowTotalHandValue();
Console.WriteLine();

player3.ShowTotalHandValue();
Console.WriteLine();

player4.ShowTotalHandValue();
Console.WriteLine();

game.AnnonceWinner();

Console.ReadLine();