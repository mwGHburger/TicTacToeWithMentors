using System;
using System.Collections.Generic;
using TicTacToe.Interface;

namespace TicTacToe
{
    public class Board : IBoard
    {
        public Board()
        {
            CreateFields();
        }
        // Board.Fields
        // Board.GetFields();
        public List<Field> Fields { get; } = new List<Field>(); 

        public int Size { get; } = 3; 

        private void CreateFields()
        {
            for(int i = 1; i < 4; i++)
            {
                for(int j = 1; j < 4; j++)
                {
                    Fields.Add(new Field(i,j,"*"));
                }
            }
        }

        public bool CheckFieldIsFree(int row, int column)
        {
            var field = GetField(row, column);
            return (field.Value == "*") ? true : false;
        }

        public void SetFieldValue(int row, int column, string symbol)
        {
            var field = GetField(row, column);
            field.Value = symbol;
        }

        private Field GetField(int row, int column)
        {
            foreach(Field field in Fields)
            {
                if (field.Row == row && field.Column == column)
                {
                    return field;
                }
            }
            // Note: Discussion Null vs Exception (https://stackoverflow.com/questions/175532/should-a-retrieval-method-return-null-or-throw-an-exception-when-it-cant-prod#:~:text=If%20it%20is%20expected%20behavior,is%20a%20matter%20of%20preference.&text=As%20a%20general%20rule%2C%20if,way%2C%20go%20with%20the%20null.)
            throw new ArgumentException("Row or column inputs are out of range");
        }
    }
}