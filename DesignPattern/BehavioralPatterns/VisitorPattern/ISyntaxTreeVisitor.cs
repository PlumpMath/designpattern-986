using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    /// <summary>
    /// Visitor interface
    /// Visitor Pattern: New operations on classes can be added without modifing the class/data structure itself
    /// Visitor can keep track by maintaining internal state information
    /// </summary>
    public interface ISyntaxTreeVisitor
    {
        /// <summary>
        /// Visit method which is invoked when visitor operates on BinaryStatement
        /// </summary>
        /// <param name="statement">The binary statement</param>
        void Visit(BinaryStatement statement);

        /// <summary>
        /// Visit method which is invoked when visitor operates on ValueStatement
        /// </summary>
        /// <param name="statement">The value statement</param>
        void Visit(ValueStatement statement);

        /// <summary>
        /// Visit method which is invoked when visitor operates on SyntaxTree
        /// </summary>
        /// <param name="statement">The Syntax Tree</param>
        void Visit(SyntaxTree statement);
    }
}
