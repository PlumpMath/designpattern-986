using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.CreationalPatterns.PrototypePattern;

namespace TSTune.DesignPattern.UnitTests.CreationalPatterns
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void ClonedClass_ShouldBe_DecoupledFromOriginalClass()
        {
            // Arrange
            int originalX = 10;
            int originalY = 20;
            int clonedX = 2000;
            int clonedY = 3000;
            var coordinate = new Coordinate(originalX, originalY);
            // Act
            var coordinateClone = coordinate.Clone() as Coordinate;
            coordinateClone.X = clonedX;
            coordinateClone.Y = clonedY;
            // Assert
            Assert.IsNotNull(coordinateClone);
            // Original object should not be touched
            Assert.AreEqual(originalX, coordinate.X);
            Assert.AreEqual(originalY, coordinate.Y);
            Assert.AreEqual(clonedX, coordinateClone.X);
            Assert.AreEqual(clonedY, coordinateClone.Y);
        }
    }
}
