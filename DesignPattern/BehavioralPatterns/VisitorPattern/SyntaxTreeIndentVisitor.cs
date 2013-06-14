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
        /// <summary>
        /// Visit method which is invoked when visitor operates on BinaryStatement.
        /// The indent is increased everytime a binary statement is found.
        /// Writes start and end of the method to the console.
        /// </summary>
        /// <param name="statement">The binary statement</param>
        public void Visit(BinaryStatement statement)
        {
            Write("Start visit BinaryStatement");
            _indent++;
            statement.Left.Accept(this);
            statement.Right.Accept(this);
            _indent--;
            Write("End visit BinaryStatement");
        }

        /// <summary>
        /// Visit method which is invoked when visitor operates on ValueStatement.
        /// Just writes start and end of the method to the console. 
        /// </summary>
        /// <param name="statement">The value statement</param>
        public void Visit(ValueStatement statement)
        {
            Write("Start visit ValueStatement");
            Write("End visit ValueStatement");       
        }

        /// <summary>
        /// Visit method which is invoked when visitor operates on SyntaxTree
        /// The indent is increased for each syntax tree.
        /// Writes start and end of the method to the console.
        /// </summary>
        /// <param name="statement">The Syntax Tree</param>
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
