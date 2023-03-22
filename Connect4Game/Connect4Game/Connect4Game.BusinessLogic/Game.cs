using System;
using Connect4Game.BusinessLogic.Contracts.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic
{
    public class Game : IGame
    {
        public string GameID { get; set; }
        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }
        public IBoard Board { get; set; }
        public IPlayer CurrentPlayer { get; set; }
        public EventHandler OnGameStarted { get; set; }
        public EventHandler OnMoveMade { get; set; }
        public EventHandler OnGameEnded { get; set; }

        public Game(string gameID, string playerID)
        {

        }

        public bool MakeMove(int col)
        {
            throw new NotImplementedException();
        }

        public void TogglePlayer()
        {
            throw new NotImplementedException();
        }

        public bool IsOver(string gameID)
        {
            throw new NotImplementedException();
        }

        public bool IsDraw(string gameID)
        {
            throw new NotImplementedException();
        }

        public IPlayer GetWinner(string gameID)
        {
            throw new NotImplementedException();
        }
    }
}
