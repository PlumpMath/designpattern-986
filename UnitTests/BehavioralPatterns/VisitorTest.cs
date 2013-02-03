using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TSTune.DesignPattern.BehavioralPatterns.VisitorPattern;
using System.Diagnostics;

namespace TSTune.DesignPattern.UnitTests.BehavioralPatterns
{
    /// <summary>
    /// Unit test for the visitor example
    /// </summary>
    [TestClass]
    public class VisitorTest
    {
        [TestMethod]
        public void SimpleVisitorTest()
        {
            // Create first statement
            var valueStatement1a = new ValueStatement("1");
            var valueStatement1b = new ValueStatement("2");
            var binaryStatement1 = new BinaryStatement(valueStatement1a, valueStatement1b);

            // Create second statement (nested)
            var valueStatement2a = new ValueStatement("3");
            var valueStatement22a = new ValueStatement("4");
            var valueStatement22b = new ValueStatement("5");
            var binaryStatement22 = new BinaryStatement(valueStatement22a, valueStatement22b);
            var binaryStatement2 = new BinaryStatement(valueStatement2a, binaryStatement22);

            var syntaxTree = new SyntaxTree(new[] { binaryStatement1, binaryStatement2 });

            // Run through the syntax tree with the simple value visitor
            Trace.WriteLine("Start SyntaxTreeValueVisitor");
            syntaxTree.Accept(new SyntaxTreeValueVisitor());
            Trace.WriteLine("End SyntaxTreeValueVisitor");
            Trace.WriteLine(string.Empty);

            // Run through the syntax tree with the indent visitor
            Trace.WriteLine("Start SyntaxTreeIndendedVisitor");
            syntaxTree.Accept(new SyntaxTreeIndentVisitor());
            Trace.WriteLine("End SyntaxTreeIndendedVisitor");
        }
    }
}
