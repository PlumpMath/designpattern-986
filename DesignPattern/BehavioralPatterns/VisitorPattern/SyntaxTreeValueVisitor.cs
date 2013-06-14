using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    /// <summary>
    /// Visitor implementation which walks over the syntax tree and fires an event everytime a value code block is found.
    /// Keeps track of the syntax tree depth by keeping a local variable. (internal state)
    /// The depth variable is a good example of how to keep state across multiple classes. 
    /// </summary>
    public class SyntaxTreeValueVisitor: ISyntaxTreeVisitor
    {
        private int _depth = 0;

        #region Visitor members
        /// <summary>
        /// Visit method which is invoked when visitor operates on BinaryStatement.
        /// Depth is increased on every level of nested binary statement.
        /// </summary>
        /// <param name="statement">The binary statement</param>
        public void Visit(BinaryStatement statement)
        {
            _depth++;
            statement.Left.Accept(this);
            statement.Right.Accept(this);
            _depth--;
        }

        /// <summary>
        /// Visit method which is invoked when visitor operates on ValueStatement.
        /// For every value statement an event is raised containing the current code block and depth.
        /// </summary>
        /// <param name="statement">The value statement</param>
        public void Visit(ValueStatement statement)
        {
            RaiseEvent(statement.Code, _depth);
        }

        /// <summary>
        /// Visit method which is invoked when visitor operates on SyntaxTree
        /// </summary>
        /// <param name="statement">The Syntax Tree</param>
        public void Visit(SyntaxTree statement)
        {
            foreach (var s in statement.Statements)
            {
                s.Accept(this);
            }
        }
        #endregion

        /// <summary>
        /// Event which is raised for each value statement
        /// </summary>
        public event EventHandler<VisitResultEventArgs> VisitResultEvent;
        
        /// <summary>
        /// Raises an event with VisitResultEventArgs
        /// </summary>
        /// <param name="code">The current code block</param>
        /// <param name="depth">The current depth</param>
        protected void RaiseEvent(string code, int depth)
        {
            OnVisitResultEvent(new VisitResultEventArgs { Value=code, Depth=depth });
        }
                
        /// <summary>
        /// Raises the VisitResultEvent if event subscribers exist
        /// </summary>
        /// <param name="e">The event args</param>
        protected virtual void OnVisitResultEvent(VisitResultEventArgs e)
        {
            if (VisitResultEvent != null)
            {
                VisitResultEvent(this, e);
            }
        }
    }
}
