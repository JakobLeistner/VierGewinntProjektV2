using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Connect4Game.RestAPI
{
    public class RTPHub
    {
        private ConnectionService connection;

        public EventHandler OnGameStarted;
        public EventHandler OnGameEnded;
        public EventHandler OnMoveMade;
        public EventHandler OnQueueChanged;

        public RTPHub()
        {

        }


    }
}
