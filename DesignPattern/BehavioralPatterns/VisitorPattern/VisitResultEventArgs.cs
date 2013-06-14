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
        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the statement depth
        /// </summary>
        public int Depth { get; set; }
    }
}
