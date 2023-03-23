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
        //hallo ich in eintest

        public RTPHub()
        {

        }
        //Hub wartet und hört zu, ob die events getriggert werden
        //gameID kommt aus Logik, denn dort wurde das event invoked 
        [HubMethodName("OnGameStarted")]
        public async Task OnGameStarted(string gameID)
        { 
            await SendMessage(gameID, "GameStarted", null);
        }

        [HubMethodName("OnGameEnded")]
        public async Task OnGameEnded(string gameID)
        {
            await SendMessage(gameID, "GameEnded", null);
        }

        [HubMethodName("OnMoveMade")]
        public async Task OnMoveMade(string gameID, Player Mover)
        {
            await SendMessage(gameID, "MoveMade", Mover);
        }

        [HubMethodName("OnQueueChanged")]
        public async Task<List<IPlayer>> OnQueueChanged(string gameID)
        {
            await SendMessage(gameID, "QueueChanged", null);
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
