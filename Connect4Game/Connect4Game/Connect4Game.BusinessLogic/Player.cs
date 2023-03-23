using System;
using Connect4Game.BusinessLogic.Contracts.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic
{
    public class Player : IPlayer
    {
        public string PlayerID { get; set; }
        private string name { get; set; }
        public string Color { get; set; }

        public Player(string playerID, string name, string color)
        {
            this.PlayerID = playerID;
            this.name = name;
            this.Color = color;
        }

        public string GetName()
        {
            return name;
        }
    }
}
