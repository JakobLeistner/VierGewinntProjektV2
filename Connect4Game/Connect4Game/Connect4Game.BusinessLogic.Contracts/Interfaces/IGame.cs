using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic.Contracts.Interfaces
{
    public interface IGame
    {
        string GameID { get; }
        IPlayer Player1 { get; }
        IPlayer Player2 { get; }
        IBoard Board { get;}
        IPlayer CurrentPlayer { get; }
        EventHandler OnGameStarted { get; set; }
        EventHandler OnMoveMade { get; set; }
        EventHandler OnGameEnded { get; set; }

        bool MakeMove(int col);

        void TogglePlayer()
        {
            throw new NotImplementedException();
        }

        bool IsOver(string gameID)
        {
            throw new NotImplementedException();
        }

        bool IsDraw(string gameID)
        {
            throw new NotImplementedException();
        }

        IPlayer GetWinner(string gameID)
        {
            throw new NotImplementedException();
        }
    }
}
