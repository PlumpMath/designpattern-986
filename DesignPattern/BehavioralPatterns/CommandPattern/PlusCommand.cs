﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.CommandPattern
{
    public class PlusCommand : ICommand<int>
    {
        private int _currentValue;
        private int _add;

        /// <summary>
        /// Constructor takes all the necessary information to execute command.
        /// </summary>
        /// <param name="currentValue">The current value</param>
        /// <param name="add">Add</param>
        public PlusCommand(int currentValue, int add)
        {
            _currentValue = currentValue;
            _add = add;
        }

        public int Execute()
        {
            _currentValue = _currentValue + _add;
            return _currentValue;
        }

        public int Undo()
        {
            _currentValue = _currentValue - _add;
            return _currentValue;
        }
    }
}
