using System;
using Xunit;

namespace TicTacToe.Tests
{
    public class BoardTests
    {
        // [Fact]
        // public void ShouldDisplayBoard3x3()
        // {
        //     var board = new Board();
        //     var expected = "* * * \n* * * \n* * * \n";

        //     var actual = board.GetBoard();

        //     Assert.Equal(expected, actual);
        // }
        
        [Fact]
        public void ShouldReturnTrue_IfFieldIsFree()
        {
            var board = new Board();

            var actual = board.CheckFieldIsFree(2,2);
            
            Assert.True(actual);
        }
        
    }
}
