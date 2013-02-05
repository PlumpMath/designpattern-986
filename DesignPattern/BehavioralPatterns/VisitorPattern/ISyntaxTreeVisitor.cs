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
        void Visit(BinaryStatement statement);
        void Visit(ValueStatement statement);
        void Visit(SyntaxTree statement);
    }
}
