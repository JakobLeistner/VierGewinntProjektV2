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
        List<IGame> GameList { get; }
        List<IPlayer> PlayerList { get; }
        List<IPlayer> Queue { get; }

        void JoinQueue(IPlayer playerID);

        IGame StartGame(IPlayer playerID1, IPlayer playerID2);

        public void MakeMoveInGame(string gameID, string playerID, int col);

        void EndGame(string gameID);

        IGame GetGameFromID(string gameID);
    }
}
