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
        //
        public int Col { get; set; }
        public int Row { get; set; }
        public int[][] Squares { get; set; }

        public Board(int col, int row)
        {
            this.ClearBoard(col, row);
        }

        public void ClearBoard(int col, int row)
        {
            col = 7;
            row = 6;

            for (int i = 0;i < col; i++)
            {
                Squares[i] = new int[col];
                for (int j = 0; j < row; j++)
                {
                    Squares = new int[row][];
                }
            }
        }

        public void MakeMove(IPlayer p, int col)
        {
            throw new NotImplementedException();
        }
    }
}
