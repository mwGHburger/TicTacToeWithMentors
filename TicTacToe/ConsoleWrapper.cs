using System;

namespace TicTacToe
{
    public class ConsoleWrapper
    {
        public virtual void Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}