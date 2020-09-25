using System;
using Xunit;

namespace TicTacToe.Tests
{
    public class BoardTests
    {
        [Fact]
        public void ShouldDisplayBoard3x3()
        {
            var board = new Board(3);
            var expected = "* * * \n* * * \n* * * \n";

            var actual = board.GetBoard();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldDisplayBoard5x5()
        {
            var board = new Board(5);
            var expected = "* * * * * \n* * * * * \n* * * * * \n* * * * * \n* * * * * \n";

            var actual = board.GetBoard();

            Assert.Equal(expected, actual);
        }
    }
}
