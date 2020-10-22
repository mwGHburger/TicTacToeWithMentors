using System.Collections.Generic;

namespace TicTacToe.Interface
{
    public interface IBoard
    {
         List<Field> Fields { get; }
         int Size { get; }
    }
}