using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    /// <summary>
    /// Base Class representing the data structure the visitor should extend with new operations
    /// In this case the statement represents a code block (Parser scenario)
    /// </summary>
    public abstract class Statement
    {
        public string Code { get; set; }

        public abstract void Accept(ISyntaxTreeVisitor visitor);
    }
}
