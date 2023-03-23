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
        public List<IGame> GameList { get; set; }
        public List<IPlayer> PlayerList { get; set; }
        public List<IPlayer> Queue { get; set; }

        public LogicController()
        {

        }

        public void JoinQueue(IPlayer playerID)
        {
            throw new NotImplementedException();
        }

        public IGame StartGame(IPlayer playerID1, IPlayer playerID2)
        {
            throw new NotImplementedException();
        }

        public void EndGame(string gameID)
        {
            throw new NotImplementedException();
        }

        public void MakeMoveInGame(string gameID, string playerID, int col)
        {
            IPlayer p = GetPlayerFromID(playerID);
            Game.MakeMove(p,col);
        }

        public IGame GetGameFromID(string gameID)
        {
            throw new NotImplementedException();
        }

        public IPlayer GetPlayerFromID(string playerID)
        {
            throw new NotImplementedException();
        }
    }
}
