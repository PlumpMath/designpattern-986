using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    public interface ISyntaxTreeVisitor
    {
        void Visit(BinaryStatement statement);
        void Visit(ValueStatement statement);
        void Visit(SyntaxTree statement);
    }
}
