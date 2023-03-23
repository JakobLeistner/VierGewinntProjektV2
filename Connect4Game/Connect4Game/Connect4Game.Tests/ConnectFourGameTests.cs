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

        // Board
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
        public void MakeMove_WhenColumnIsOutOfRange_ShouldThrowArgumentOutOfRange(Player player, int col)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Game.MakeMove(player, col));
        }

        [TestMethod]
        public void TogglePlayer_ChangePlayer1ToPlayer2()
        {
            // checken, ob Player1 (CurrentPlayer) oder Player2 (CurrentPlayer) -> wechseln
            Game.Player1 = Game.CurrentPlayer;
            Game.TogglePlayer();
            Assert.IsTrue(Game.CurrentPlayer == Game.Player2);
        }

        [TestMethod]
        public void TogglePlayer_ChangePlayer2ToPlayer1()
        {
            Game.Player2 = Game.CurrentPlayer;
            Game.TogglePlayer();
            Assert.IsTrue(Game.CurrentPlayer == Game.Player1);
        }

        [TestMethod]
        public void IsOver_WhenPlayer2Wins_ShouldReturnTrue()
        {
            Game.GetWinner() = Player2;
            Assert.IsTrue(Game.IsOver());
        }

        [TestMethod]
        public void IsOver_WhenPlayer1Wins_ShouldReturnTrue()
        {
            Game.GetWinner() = Player1;
            Assert.IsTrue(Game.IsOver());
        }

        [TestMethod]
        public void IsOver_WhenGameIsDraw_ShouldReturnTrue()
        {
            Game.IsDraw() = true;
            Assert.IsTrue(Game.IsOver());
        }

        [TestMethod]

        [TestMethod]
        public void IsDraw_WhenGameBoardIsFullAndNoWinner_ShouldReturnTrue() // isFalse -> andere Method
        {

            Game.Board.Squares = new int[][] {
              new int[]{1,2,2,2,1,2,2},
              new int[]{1,1,1,2,2,1,1},
              new int[]{2,2,2,1,1,1,2},
              new int[]{2,1,1,1,2,2,1},
              new int[]{1,1,2,2,1,2,2},
              new int[]{1,2,1,2,2,1,1},
            };

            Assert.IsTrue(Game.IsDraw());
        }

        [TestMethod]
        public void GetWinner_WhenPlayer1Wins_ShouldReturnWinner()
        {
            // Board wo ein Player gewonnen hat
            // Board wo keinen Gewinner gibt -> return null
            // Assert.AreSame(Player1, Game.GetWinner());
        }

        [TestMethod]
        public void ClearBoard_WhenGameStarted_ShouldEmptyBoard(int col, int row)
        {
            // Game erstellen, und Board (prüfen ob alles null?)
            // alles null ? -> areequal-method
            // ClearBoard ist nur zum Initialisieren
            // MakeMove - Positionen ausdenken - ClearBoard machen
            if (Game.OnGameStarted == null)
            {
                Assert.ThrowsException<InvalidOperationException>(() => Game.OnGameStarted);
            }

            Board.ClearBoard(col, row);
        }

        // Game.Board.Squares -> MakeMove oder IsOver oder IsDraw als Bsp
        // eine Zeile voll ? Fehlermeldung
    }
}