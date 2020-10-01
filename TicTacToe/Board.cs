using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        public Board()
        {
            CreateFields();
        }

        public List<Field> Fields = new List<Field>(); 

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
            foreach(Field field in Fields)
            {
                if (field.Row == row && field.Column == column)
                {
                    return (field.Value == "*") ? true : false;
                }
            }
            return false;
        }

        
    }
}