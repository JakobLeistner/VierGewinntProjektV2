using Connect4Game.BusinessLogic.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4Game.BusinessLogic
{
    public class Board : IBoard
    {
        public int Col { get; set; }
        public int Row { get; set; }
        public int[][] Squares { get; set; }

        public Board(int col, int row)
        {
            this.ClearBoard(col, row);
        }

        public void ClearBoard(int col, int row)
        {
            throw new NotImplementedException();
        }

        public void MakeMove(int col)
        {
            throw new NotImplementedException();
        }
    }
}
