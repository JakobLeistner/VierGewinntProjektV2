using System;
using Connect4Game.BusinessLogic.Contracts.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic
{
    public class LogicController : ILogicController
    {
        public IGame[] GameList { get; set; }
        public IPlayer[] PlayerList { get; set; }
        public IPlayer[] Queue { get; set; }

        public LogicController()
        {

        }

        public void JoinQueue(Player playerID)
        {
            throw new NotImplementedException();
        }

        public Game StartGame(Player playerID1, Player playerID2)
        {
            throw new NotImplementedException();
        }

        public void EndGame(string gameID)
        {
            throw new NotImplementedException();
        }

        public Game GetGameFromID(string gameID)
        {
            throw new NotImplementedException();
        }

        public Player GetPlayerFromID(string playerID)
        {
            throw new NotImplementedException();
        }
    }
}
