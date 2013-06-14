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
        /// <summary>
        /// Constructor takes a left and right element of a binary expression
        /// </summary>
        /// <param name="left">Left statement</param>
        /// <param name="right">Right statement</param>
        public BinaryStatement(Statement left, Statement right)
        {
            Left = left;
            Right = right;
        }

        /// <summary>
        /// The left statement
        /// </summary>
        public Statement Left { get; set; }

        /// <summary>
        /// The right statement
        /// </summary>
        public Statement Right { get; set; }

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
