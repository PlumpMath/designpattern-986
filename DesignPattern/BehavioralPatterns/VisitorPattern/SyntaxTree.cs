using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    /// <summary>
    /// Specific element representing the whole code block / List of statements
    /// </summary>
    public class SyntaxTree: Statement
    {
        /// <summary>
        /// The contructor takes a list of statements
        /// </summary>
        /// <param name="statements">List of statements</param>
        public SyntaxTree(IList<Statement> statements)
        {
            Statements = statements;
        }

        /// <summary>
        /// The syntax tree consists of a list of statements
        /// </summary>
        public IList<Statement> Statements { get; set; }

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
