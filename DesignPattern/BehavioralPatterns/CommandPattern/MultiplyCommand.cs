using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.CommandPattern
{
    /// <summary>
    /// Command for a simple multiply operation of two integers
    /// </summary>
    public class MultiplyCommand : ICommand<int>
    {
        private int _currentValue;
        private int _factor;

        /// <summary>
        /// Constructor takes all the necessary information to execute command.
        /// </summary>
        /// <param name="currentValue">The current value</param>
        /// <param name="factor">The factor for the multiply operation</param>
        public MultiplyCommand(int currentValue, int factor)
        {
            _currentValue = currentValue;
            _factor = factor;
        }

        /// <summary>
        /// The command method which multiplies the two given numbers 
        /// </summary>
        /// <returns>The multiplication result</returns>
        public int Execute()
        {
            _currentValue = _currentValue * _factor;
            return _currentValue;
        }

        /// <summary>
        /// The Multiply command is undone using the division operator
        /// </summary>
        /// <returns>The original value</returns>
        public int Undo()
        {
            _currentValue = _currentValue / _factor;
            return _currentValue;
        }
    }
}
