using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic.Contracts.Interfaces
{
    public interface IPlayer
    {
        string PlayerID { get; }
        string color { get; }

        string GetName();
    }
}
