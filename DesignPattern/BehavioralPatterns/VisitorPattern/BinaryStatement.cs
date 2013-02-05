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
    public class BinaryStatement: Statement
    {
        public BinaryStatement(Statement left, Statement right)
        {
            Left = left;
            Right = right;
        }

        public Statement Left { get; set; }
        public Statement Right { get; set; }

        public override void Accept(ISyntaxTreeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
