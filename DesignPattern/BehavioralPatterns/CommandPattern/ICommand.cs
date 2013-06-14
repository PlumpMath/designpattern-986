using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.CommandPattern
{
    /// <summary>
    /// Simple command interface with undo features
    /// Redo can be implemented by re-executing the execute method or definition additional method
    /// </summary>
    public interface ICommand<T>
    {
        /// <summary>
        /// Execute method of the command
        /// </summary>
        /// <returns>Generic result of the execute method</returns>
        T Execute();

        /// <summary>
        /// Undo method which reverts the command
        /// </summary>
        /// <returns>Generic result of the undo method</returns>
        T Undo();
    }
}
