using System;

namespace TicTacToe
{
    public class ConsoleWrapper : IConsoleWrapper
    {
        public void Write(string input)
        {
            Console.WriteLine(input);
        }

        public string Read()
        {
            return Console.ReadLine();
        }
    }
}