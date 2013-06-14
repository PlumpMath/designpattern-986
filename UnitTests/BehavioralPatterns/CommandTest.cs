using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.BehavioralPatterns.CommandPattern;

namespace TSTune.DesignPattern.UnitTests.BehavioralPatterns
{
    /// <summary>
    /// Test class for the Command Pattern
    /// </summary>
    [TestClass]
    public class CommandTest
    {
        private Stack<ICommand<int>> _undoCommands = new Stack<ICommand<int>>();
        
        /// <summary>
        /// This test shows how a Do-Undo functionality could be implemented using the command pattern.
        /// It preserves a stack of commands to remember the history and enable the Undo scenario.
        /// In this case multiple commands are executed and three plus commands are undone.
        /// </summary>
        [TestMethod]
        public void PlusCommand_ShouldBe_Undone()
        {
            // Arrange
            var initValue = 10;

            // Act
            var command1 = new MultiplyCommand(initValue, 2);
            var command2 = new PlusCommand(Do(command1), 5);
            var command3 = new PlusCommand(Do(command2), 3);
            var command4 = new PlusCommand(Do(command3), 7);
            var result = Do(command4);
            // Undo all plus commands
            var undoResultPlusCommands = Undo(3);
            // Undo multiply command
            var undoResult = Undo(1);

            // Assert
            Assert.AreEqual(initValue * 2 + 5 + 3 + 7, result);
            Assert.AreEqual(initValue * 2, undoResultPlusCommands);
            Assert.AreEqual(initValue, undoResult);
        }

        private int Do(ICommand<int> command)
        {
            _undoCommands.Push(command);
            return command.Execute();
        }

        private int Undo(int levels)
        {
            var result = -1;
            for (int i = levels; i > 0; i--)
            {
                if (_undoCommands.Count != 0)
                {
                    var command = _undoCommands.Pop();
                    result = command.Undo();
                }
            }

            return result;
        }

    }
}
