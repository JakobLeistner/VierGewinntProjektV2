using Connect4Game.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Connect4Game.Tests
{
    [TestClass]
    public class ConnectFourGameTests
    {
        //Player
        private string name;

        // Game
        Game Game;

        Player Player1;
        Player Player2;
        Player CurrentPlayer;
        Player Winner;

        Board Board;

        [TestInitialize]
        public void Init()
        {
            // Game
            Game = new Game("", ""); // GameID
            Player1 = new Player("", "", ""); // PlayerID, name, Color
            Player2 = new Player("", "", "");
            CurrentPlayer = new Player("", "", "");
            Winner = new Player("", "", "");
        }

        // Player
        [TestMethod]
        public void GetName_WhenNamesAreSame_NamesMatch()
        {
            name = "";
            Assert.AreSame(name, CurrentPlayer.GetName());
        }

        // Game
        [TestMethod]
        [DataRow(10)]
        [DataRow(-3)]
        public void MakeMove_WhenColumnIsOutOfRange_ShouldThrowArgumentOutOfRange(Player p, int col)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Game.MakeMove(p, col));
        }

        [TestMethod]
        public void TogglePlayer_PlayerIsChanging()
        {
            Game.TogglePlayer();
        }

        [TestMethod]
        public void IsOver_WhenGameEnded_ShouldReturnTrue(string gameID)
        {
            Assert.IsTrue(Game.IsOver(gameID));
        }

        [TestMethod]
        public void IsDraw_WhenGameIsDraw_ShouldReturnTrue(string gameID)
        {
            Assert.IsTrue(Game.IsDraw(gameID));
        }

        [TestMethod]
        public void GetWinner_WhenPlayer1Wins_ShouldReturnWinner(string gameID)
        {
            Assert.AreSame(Winner, Game.GetWinner(gameID));
        }

    }
}