using System.Runtime.CompilerServices;
using System;
using Xunit;

namespace TicTacToe.Tests
{
    public class BoardTests
    {
        
        [Fact]
        public void ShouldReturnTrue_IfFieldIsFree()
        {
            var board = new Board();

            var actual = board.CheckFieldIsFree(2,2);
            
            Assert.True(actual);
        }
        
        [Fact]
        public void ShouldReturnFalse_IfFieldIsNotFree()
        {
            var board = new Board();
            board.SetFieldValue(2,2,"X");

            var actual = board.CheckFieldIsFree(2,2);
            
            Assert.False(actual);
        }

        [Fact]
        public void SetFieldValue_ShouldSetValue_AtGivenFieldPosition()
        {
            var board = new Board();
            
            board.SetFieldValue(2,2,"X");
            
            Field testField = null; // Note: Need to assign variable a value
            foreach(Field field in board.Fields)
            {
                if (field.Row == 2 && field.Column == 2)
                {
                    testField = field;
                }
            }
            Assert.Equal("X", testField.Value);
        }

        [Fact]
        public void ShouldThrowException_ForInputsOutOfRange()
        {
            var board = new Board();
            var exceptionMessage = "Row or column inputs are out of range";

            var ex = Assert.Throws<ArgumentException>(() => board.CheckFieldIsFree(4,2));
            
            Assert.Equal(exceptionMessage, ex.Message);
        }
    }
}
