using System;
using Connect4Game.BusinessLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic.Contracts.Interfaces
{
    public interface ILogicController
    {
        IGame[] GameList { get; }
        IPlayer[] PlayerList { get; }
        IPlayer[] Queue { get; }

        void JoinQueue(IPlayer playerID)
        {
            throw new NotImplementedException();
        }

        IGame StartGame(IPlayer playerID1, IPlayer playerID2)
        {
            throw new NotImplementedException();
        }

        void EndGame(string gameID)
        {
            throw new NotImplementedException();
        }

        IGame GetGameFromID(string gameID)
        {
            throw new NotImplementedException();
        }
    }
}
