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
        public void Visitor_Should_FindAllValueStatements()
        {
            // Arrange
            var firstValue = "1";
            var fifthValue = "5";
            
            // Create first statement
            var valueStatement1a = new ValueStatement(firstValue);
            var valueStatement1b = new ValueStatement("2");
            var binaryStatement1 = new BinaryStatement(valueStatement1a, valueStatement1b);

            // Create second statement (nested)
            var valueStatement2a = new ValueStatement("3");
            var valueStatement22a = new ValueStatement("4");
            var valueStatement22b = new ValueStatement(fifthValue);
            var binaryStatement22 = new BinaryStatement(valueStatement22a, valueStatement22b);
            var binaryStatement2 = new BinaryStatement(valueStatement2a, binaryStatement22);

            var syntaxTree = new SyntaxTree(new[] { binaryStatement1, binaryStatement2 });

            var result = new List<string>();
            var syntaxTreeValueVisitor = new SyntaxTreeValueVisitor();
            syntaxTreeValueVisitor.VisitResultEvent += (sender, e) =>
            {
                Trace.WriteLine(string.Format("Level {0}, Value Expression {1}", e.Depth, e.Value));
                result.Add(e.Value);
            };

            // Act
            // Run through the syntax tree with the simple value visitor
            Trace.WriteLine("Start SyntaxTreeValueVisitor");
            syntaxTree.Accept(syntaxTreeValueVisitor);
            
            Trace.WriteLine("End SyntaxTreeValueVisitor");
            Trace.WriteLine(string.Empty);

            // Run through the syntax tree with the indent visitor
            Trace.WriteLine("Start SyntaxTreeIndendedVisitor");
            syntaxTree.Accept(new SyntaxTreeIndentVisitor());
            Trace.WriteLine("End SyntaxTreeIndendedVisitor");

            // Assert
            Assert.AreEqual(5, result.Count);
            Assert.AreEqual(firstValue, result[0]);
            Assert.AreEqual(fifthValue, result[4]);
        }
    }
}
