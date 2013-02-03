using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    public class SyntaxTreeValueVisitor: ISyntaxTreeVisitor
    {
        private int _depth = 0;

        public void Visit(BinaryStatement statement)
        {
            _depth++;
            statement.Left.Accept(this);
            statement.Right.Accept(this);
            _depth--;
        }

        public void Visit(ValueStatement statement)
        {
            Trace.WriteLine(string.Format("Level {0}, Value Expression {1}", _depth, statement.Code));
        }

        public void Visit(SyntaxTree statement)
        {
            foreach (var s in statement.Statements)
            {
                s.Accept(this);
            }
        }
    }
}
