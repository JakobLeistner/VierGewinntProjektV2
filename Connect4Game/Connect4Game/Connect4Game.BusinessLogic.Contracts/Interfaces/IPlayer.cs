using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic.Contracts.Interfaces
{
    public interface IPlayer
    {
        int PlayerID { get; }
        string color { get; }

        string GetName()
        {
            return "";
        }
    }
}
