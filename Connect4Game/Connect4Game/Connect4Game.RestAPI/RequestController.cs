
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

        public Player RegisterPlayer(string name, string color) //RegisterPlayer würde mir mehr gefallen
        {
            //neue playerID generieren
            Guid uuid = Guid.NewGuid();
            string newPlayerID = uuid.ToString();

            Player p = new Player(newPlayerID, name, color);
            logic.PlayerList.Add(p);
            return p;
        }
        public Game CreateGame(string playerID)
        {
            //neue gameID generieren
            Guid uuid = Guid.NewGuid();
            string newGameID = uuid.ToString();
            Game g = new Game(newGameID, playerID);
            logic.GameList.Add(g);
            return g;
        }
        public void JoinGame(string playerID, string gameID)
        {
            logic.GetGameFromID(gameID).Player2 = logic.GetPlayerFromID(playerID); //Player2 muss uach set sein in der logic oder? // ic hmuss es hier doch ändern

        }
        //FontEnd triggers
        public void LeaveGame(string playerID)
        {
            //Player leaves prematurely, this is not the natural way that a game ends.
            //The natural way, meaning somebody won or the game resulted in a draw, would trigger the "OnGameEnded" Event
            //remove the game which the player was playing
            foreach (IGame g in logic.GameList)
            {
                if ((g.Player1.PlayerID == playerID) || (g.Player2.PlayerID == playerID))
                {
                    logic.GameList.Remove(g);
                }
            }
        }
        public void MakeMove(string playerID, int col, string gameID)
        {
            logic.MakeMoveInGame(gameID, playerID, col);
        }
        
        //FrontEnd request and gets Status Update
        public IGame GetStatus(string gameID)
        {
            return logic.GetGameFromID(gameID);  //Interface oder nicht - das ist hier die Frage
        }
        public List<IPlayer> GetQueue()
        {
            return logic.Queue;
        }
    }
}
