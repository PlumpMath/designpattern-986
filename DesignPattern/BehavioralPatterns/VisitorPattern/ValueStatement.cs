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
        public ValueStatement(string code)
        {
            Code = code;
        }

        public override void Accept(ISyntaxTreeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
