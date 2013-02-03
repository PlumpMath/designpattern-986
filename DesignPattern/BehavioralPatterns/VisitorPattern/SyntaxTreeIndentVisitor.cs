using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    public class SyntaxTreeIndentVisitor: ISyntaxTreeVisitor
    {
        private int _indent = 0;

        public void Visit(BinaryStatement statement)
        {
            Write("Start visit BinaryStatement");
            _indent++;
            statement.Left.Accept(this);
            statement.Right.Accept(this);
            _indent--;
            Write("End visit BinaryStatement");
        }

        public void Visit(ValueStatement statement)
        {
            Write("Start visit ValueStatement");
            Write("End visit ValueStatement");       
        }

        public void Visit(SyntaxTree statement)
        {
            Write("Start visit SyntaxTree");
            _indent++;
            foreach (var s in statement.Statements)
            {
                s.Accept(this);
            }
            _indent--;
            Write("End visit SyntaxTree");
        }

        private void Write(string message)
        {
            Trace.IndentLevel = _indent;
            Trace.WriteLine(message);
        }
    }
}
