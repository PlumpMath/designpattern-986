using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.BehavioralPatterns.VisitorPattern
{
    public abstract class Statement
    {
        public string Code { get; set; }

        public abstract void Accept(ISyntaxTreeVisitor visitor);
    }
}
