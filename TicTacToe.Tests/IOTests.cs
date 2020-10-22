using System.Collections.Generic;
using Moq;
using Xunit;
using TicTacToe.Interface;

namespace TicTacToe.Tests
{
    public class IOTests
    {
        // TODO: Started here
        
        [Fact] 
        public void ShouldDisplayEmptyBoard()
        {
            var mockConsoleWrapper = new Mock<IConsoleWrapper>();
            var fields = new List<Field>() 
            {
                new Field(1,1,"*"),
                new Field(1,2,"*"),
                new Field(1,3,"*"),
                new Field(2,1,"*"),
                new Field(2,2,"*"),
                new Field(2,3,"*"),
                new Field(3,1,"*"),
                new Field(3,2,"*"),
                new Field(3,3,"*")
            };
            var mockBoard = SetupBoard(fields);
            var IO = new IO(mockBoard.Object, mockConsoleWrapper.Object);

            IO.ShowBoard();

            mockConsoleWrapper.Verify(x => x.Write("* * *\n* * *\n* * *\n"));
        }

        [Fact] 
        public void ShouldDisplayBoard()
        {
            var mockConsoleWrapper = new Mock<IConsoleWrapper>();
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
            var mockBoard = SetupBoard(fields);
            var IO = new IO(mockBoard.Object, mockConsoleWrapper.Object);

            IO.ShowBoard();

            mockConsoleWrapper.Verify(x => x.Write("* O *\n* X *\n* * *\n"));
        }

        [Fact]
        public void AskForInputShouldReadConsoleInput()
        {
            var mockConsoleWrapper = new Mock<IConsoleWrapper>();
            var mockBoard = new Mock<IBoard>();
            var IO = new IO(mockBoard.Object, mockConsoleWrapper.Object);
            
            mockConsoleWrapper.Setup(x => x.Read()).Returns("1,1");
            var actual = IO.AskForInput("Provide input: ");

            mockConsoleWrapper.Verify(x => x.Read());
            Assert.Equal("1,1", actual);
        }

        [Fact]
        public void AskForInputShouldWriteToConsole()
        {
            var mockConsoleWrapper = new Mock<IConsoleWrapper>();
            var mockBoard = new Mock<IBoard>();
            var IO = new IO(mockBoard.Object, mockConsoleWrapper.Object);
            var prompt = "Provide input: ";
            
            var actual = IO.AskForInput(prompt);
            mockConsoleWrapper.Verify(x => x.Write(prompt));
        }

        //TODO: Validate input - Consider makign a Coordinate class to be responsible for handling this validation.

        private Mock<IBoard> SetupBoard(List<Field> fields)
        {
            Mock<IBoard> mockBoard = new Mock<IBoard>();
            mockBoard.Setup(x => x.Fields).Returns(fields);
            mockBoard.Setup(x => x.Size).Returns(3);

            return mockBoard;
        }
    }
}