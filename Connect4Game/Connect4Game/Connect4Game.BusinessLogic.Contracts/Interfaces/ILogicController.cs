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

        void JoinQueue(IPlayer playerID);

        IGame StartGame(IPlayer playerID1, IPlayer playerID2);

        void EndGame(string gameID);

        IGame GetGameFromID(string gameID);
    }
}
