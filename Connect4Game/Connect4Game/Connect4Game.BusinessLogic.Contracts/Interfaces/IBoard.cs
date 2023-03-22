using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic.Contracts.Interfaces
{
    public interface IBoard
    {
        int Col { get;}
        int Row { get; }
        int[][] Squares { get; }

        void ClearBoard(int col, int row);

        void MakeMove(int col);
    }
}
