using System;
namespace TicTacToe
{
    public class Board
    {
        public Board(int size)
        {
            this._size = size;
        }

        private int _size;

        public string GetBoard()
        {
            string board = "";
            for(int i = 0; i < this._size; i++)
            {
                for(int j = 0;j < this._size; j++)
                {
                    board = String.Concat(board, "* ");
                }
                board = String.Concat(board,"\n");
            }
            return board;
        }
    }
}