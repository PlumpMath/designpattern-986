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
        public SyntaxTree(IList<Statement> statements)
        {
            Statements = statements;
        }

        public IList<Statement> Statements { get; set; }

        public override void Accept(ISyntaxTreeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
