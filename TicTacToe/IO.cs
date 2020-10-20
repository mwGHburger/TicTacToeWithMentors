using TicTacToe.Interface;
namespace TicTacToe
{
    public class IO
    {
        public IBoard Board { get; }
        public IConsoleWrapper ConsoleWrapper { get; }
        public IO(IBoard board, IConsoleWrapper consoleWrapper)
        {
            Board = board;
            ConsoleWrapper = consoleWrapper;
        }

        public void ShowBoard()
        {
            var boardString = CreateBoardString();
            ConsoleWrapper.Write(boardString);
        }

        public string AskForInput(string prompt)
        {
            ConsoleWrapper.Write(prompt);
            return ConsoleWrapper.Read();
        }

        private string CreateBoardString()
        {
            var boardString = "";
            foreach(Field field in Board.Fields)
            {
                boardString += (field.Column == Board.Size) ? $"{field.Value}\n" : $"{field.Value} ";
            }
            return boardString;
        }
    }
}