using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.CommandPattern
{
    /// <summary>
    /// Simple command interface with undo features
    /// Redo can be implemented re-executing the execute method or by definition additional method
    /// </summary>
    public interface ICommand<T>
    {
        T Execute();
        T Undo();
    }
}
