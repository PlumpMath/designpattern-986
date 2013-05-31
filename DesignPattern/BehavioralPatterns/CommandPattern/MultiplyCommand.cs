using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.CommandPattern
{
    public class MultiplyCommand : ICommand<int>
    {
        private int _currentValue;
        private int _factor;

        /// <summary>
        /// Constructor takes all the necessary information to execute command.
        /// </summary>
        /// <param name="currentValue">The current value</param>
        /// <param name="factor">Factor</param>
        public MultiplyCommand(int currentValue, int factor)
        {
            _currentValue = currentValue;
            _factor = factor;
        }

        public int Execute()
        {
            _currentValue = _currentValue * _factor;
            return _currentValue;
        }

        public int Undo()
        {
            _currentValue = _currentValue / _factor;
            return _currentValue;
        }
    }
}
