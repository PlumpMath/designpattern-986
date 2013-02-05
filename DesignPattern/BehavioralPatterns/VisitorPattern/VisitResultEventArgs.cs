using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    /// <summary>
    /// Event fired by the SyntaxTreeValueVisitor everytime a ValueStatement object is visited
    /// </summary>
    public class VisitResultEventArgs: EventArgs
    {
        public string Value { get; set; }
        public int Depth { get; set; }
    }
}
