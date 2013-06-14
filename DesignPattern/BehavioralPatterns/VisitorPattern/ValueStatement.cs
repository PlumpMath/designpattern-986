using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    /// <summary>
    /// Specific element representing a code block
    /// </summary>
    public class ValueStatement: Statement
    {
        /// <summary>
        /// Contructor for a simple value statement
        /// </summary>
        /// <param name="code">The code block</param>
        public ValueStatement(string code)
        {
            Code = code;
        }

        /// <summary>
        /// Accept method for the visitor
        /// </summary>
        /// <param name="visitor">The visitor</param>
        public override void Accept(ISyntaxTreeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
