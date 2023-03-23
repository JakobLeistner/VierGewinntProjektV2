using Connect4Game.BusinessLogic;
using Connect4Game.BusinessLogic.Contracts.Interfaces;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Connect4Game.RestAPI
{
    public class RTPHub : Hub
    {
        private ConnectionService connection;
        private LogicController logic;

        //public EventHandler OnGameStarted;
        //public EventHandler OnGameEnded;
        //public EventHandler OnMoveMade;
        //public EventHandler OnQueueChanged;

        public RTPHub()
        {

        }
        //Hub wartet und hört zu, ob die events getriggert werden
        [HubMethodName("OnGameStarted")]
        //gameID kommt aus logik, denn dort wurde das event invoked 
        public async Task OnGameStarted(Player winner, string gameID) 
        { 
            await SendMessage(gameID, "GameFinished", winner);
        }

        private async Task SendMessage(string gameID, string message, object data) //sends messages to both players from one game
        {
            string Player1ConnectionID = connection.PlayerIDToConnectionID[logic.GetGameFromID(gameID).Player1.PlayerID];
            await Clients.Client(Player1ConnectionID).SendAsync(message, data);

            string Player2ConnectionID = connection.PlayerIDToConnectionID[logic.GetGameFromID(gameID).Player2.PlayerID];
            await Clients.Client(Player2ConnectionID).SendAsync(message, data);
        }
    }
}
