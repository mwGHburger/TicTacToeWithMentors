namespace TicTacToe
{
    public class Field
    {
        public int Row { get; }
        public int Column { get; }
        public string Value { get; }

        public Field(int row, int column, string value) {
            this.Row = row;
            this.Column = column;
            this.Value = value;
        }
    }
}