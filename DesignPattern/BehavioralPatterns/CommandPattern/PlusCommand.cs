using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.CommandPattern
{
    /// <summary>
    /// Command for a simple addition operation of two integers
    /// </summary>
    public class PlusCommand : ICommand<int>
    {
        private int _currentValue;
        private int _add;

        /// <summary>
        /// Constructor takes all the necessary information to execute command.
        /// </summary>
        /// <param name="currentValue">The current value</param>
        /// <param name="add">The value to add</param>
        public PlusCommand(int currentValue, int add)
        {
            _currentValue = currentValue;
            _add = add;
        }

        /// <summary>
        /// The command method which adds the two given numbers 
        /// </summary>
        /// <returns>The addition result</returns>
        public int Execute()
        {
            _currentValue = _currentValue + _add;
            return _currentValue;
        }

        /// <summary>
        /// The Addition command is undone using the minus operator
        /// </summary>
        /// <returns>The original value</returns>
        public int Undo()
        {
            _currentValue = _currentValue - _add;
            return _currentValue;
        }
    }
}
