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
        public int PlayerID { get; set; }
        private int name { get; set; }
        public string color { get; set; }

        public Player(string playerID, string name, string color)
        {

        }

        public string GetName()
        {
            return"";
        }
    }
}
