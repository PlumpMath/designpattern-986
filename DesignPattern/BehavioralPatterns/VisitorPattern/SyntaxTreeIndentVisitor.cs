using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    /// <summary>
    /// Sample implementation for a visitor with indented output
    /// Keeps track of the syntax tree depth by keeping a local variable (internal state)
    /// </summary>
    public class SyntaxTreeIndentVisitor: ISyntaxTreeVisitor
    {
        private int _indent = 0;

        #region Visitor members
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
        #endregion

        private void Write(string message)
        {
            Trace.IndentLevel = _indent;
            Trace.WriteLine(message);
        }
    }
}
