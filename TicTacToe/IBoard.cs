using System.Collections.Generic;

namespace TicTacToe
{
    public interface IBoard
    {
         List<Field> Fields { get; }
         int Size { get; }
    }
}