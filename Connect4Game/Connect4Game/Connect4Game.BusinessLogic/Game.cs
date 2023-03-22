using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic
{
    public class Game
    {
        string GameID;
        Player Player1;
        Player Player2;
        Board Board;
        Player CurrentPlayer;
        EventHandler OnGameStarted;
        EventHandler OnMoveMade;
        EventHandler OnGameEnded;

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

        public Player GetWinner(string game_ID)
        {
            throw new NotImplementedException();
        }
    }
}
