namespace TicTacToe
{
    public class IO
    {
        public Board Board { get; }
        public ConsoleWrapper ConsoleWrapper { get; }
        public IO(Board board, ConsoleWrapper consoleWrapper)
        {
            Board = board;
            ConsoleWrapper = consoleWrapper;
        }

        public void ShowBoard()
        {
            ConsoleWrapper.Write("* * *\n* * *\n* * *");
        }
    }
}