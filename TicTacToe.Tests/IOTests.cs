using System.Collections.Generic;
using Moq;
using Xunit;

namespace TicTacToe.Tests
{
    public class IOTests
    {
        // TODO: Started here
        [Fact] 
        // TODO: Revisit
        public void ShouldDisplayEmptyBoard()
        {
            var mockBoard = new Mock<Board>();
            var mockConsoleWrapper = new Mock<ConsoleWrapper>();
            var IO = new IO(mockBoard.Object, mockConsoleWrapper.Object);
            
            IO.ShowBoard();

            mockConsoleWrapper.Verify(x => x.Write("* * *\n* * *\n* * *"));
        }

        [Fact] 
        // TODO: Revisit
        public void ShouldDisplayBoard()
        {
            var mockBoard = new Mock<Board>();
            var mockConsoleWrapper = new Mock<ConsoleWrapper>();
            var IO = new IO(mockBoard.Object, mockConsoleWrapper.Object);
            var fields = new List<Field>() 
            {
                new Field(1,1,"*"),
                new Field(1,2,"O"),
                new Field(1,3,"*"),
                new Field(2,1,"*"),
                new Field(2,2,"X"),
                new Field(2,3,"*"),
                new Field(3,1,"*"),
                new Field(3,2,"*"),
                new Field(3,3,"*")
            };

            mockBoard.Setup(x => x.Fields).Returns(fields);
            
            IO.ShowBoard();

            mockConsoleWrapper.Verify(x => x.Write("* O *\n* X *\n* * *"));
        }
    }
}