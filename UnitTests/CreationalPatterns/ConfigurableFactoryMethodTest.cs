using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;
using TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.ConfigurableFactoryMethod;
using TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod;

namespace TSTune.DesignPattern.UnitTests.CreationalPatterns
{
    /// <summary>
    /// Test class for the Factory Method Pattern
    /// </summary>
    [TestClass]
    public class ConfigurableFactoryMethodTest
    {
        /// <summary>
        /// The unit test is configured to use the XmlSerializer (app key "OrderSerializer" =  "XmlSerializer")
        /// This test validates that the correct serializer is selected based on the configuration entry.
        /// </summary>
        [TestMethod]
        public void FactoryMethod_Should_ReturnXmlSerializer()
        {
            // Arrange
            var order = new Order
            {
                Id = 123,
                Name = "Test Order",
                Placed = DateTime.UtcNow
            };
            var serializer = OrderSerializerFactory.GetSerializer();

            // Act
            var result = serializer.Serialize(order);

            // Assert
            Assert.IsInstanceOfType(serializer, typeof(OrderXmlSerializer));
            Assert.IsNotNull(result);
        }
    }
}
