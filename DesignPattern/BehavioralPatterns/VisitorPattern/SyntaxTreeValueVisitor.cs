using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    /// <summary>
    /// Visitor implementation which walks over the syntax tree and fires an event everytime a value code block is found
    /// Keeps track of the syntax tree depth by keeping a local variable (internal state)
    /// </summary>
    public class SyntaxTreeValueVisitor: ISyntaxTreeVisitor
    {
        private int _depth = 0;

        #region Visitor members
        public void Visit(BinaryStatement statement)
        {
            _depth++;
            statement.Left.Accept(this);
            statement.Right.Accept(this);
            _depth--;
        }

        public void Visit(ValueStatement statement)
        {
            RaiseEvent(statement.Code, _depth);
        }

        public void Visit(SyntaxTree statement)
        {
            foreach (var s in statement.Statements)
            {
                s.Accept(this);
            }
        }
        #endregion

        public event EventHandler<VisitResultEventArgs> VisitResultEvent;
        
        protected void RaiseEvent(string code, int depth)
        {
            OnVisitResultEvent(new VisitResultEventArgs { Value=code, Depth=depth });
        }
                
        protected virtual void OnVisitResultEvent(VisitResultEventArgs e)
        {
            if (VisitResultEvent != null)
            {
                VisitResultEvent(this, e);
            }
        }
    }
}
