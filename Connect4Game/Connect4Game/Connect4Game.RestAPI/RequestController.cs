
using Connect4Game.BusinessLogic;
using Connect4Game.BusinessLogic.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Connect4Game.RestAPI
{
    public class RequestController
    {
        private ConnectionService connection;
        private LogicController logic;
        public RequestController()
        {
        }

        public Player SetName(string name) //RegisterPlayer würde mir mehr gefallen
        {
            Player p = new Player(name);
            logic.PlayerList.Add(p);
            return p;
        }
        public Game CreateGame(string playerID)
        {
            //neue gameID generieren
            Guid uuid = Guid.NewGuid();
            string gameID = uuid.ToString();
            Game g = new Game(gameID, playerID);
            logic.GameList.Add(g);
            return g;
        }
        public void JoinGame(string playerID, string gameID)
        {
            logic.GetGameFromID(gameID).Player2 = logic.GetPlayerFromID(playerID);
            //trigger event OnGameStarted?

        }
        public void LeaveGame(string playerID)
        {
            //remove the game which the player was playing
            foreach (Game g in logic.GameList)
            {
                if ((g.Player1.playerID == playerID) || (g.Player2.playerID == playerID))
                {
                    logic.GameList.Remove(g);
                }
            }
        }
        public void MakeMove(string playerID, int col, string gameID)
        {
            //trigger event OnMoveMade?

        }
        public Game GetStatus(string gameID)
        {
            return logic.GetGameFromID(gameID);
        }
        public IPlayer[] GetQueue()
        {
            return logic.Queue;
        }
    }
}
