using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;
using TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.ConfigurableFactoryMethod;
using TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.DynamicFactoryMethod;

namespace TSTune.DesignPattern.UnitTests.CreationalPatterns
{
    [TestClass]
    public class ConfigurableFactoryMethodTest
    {
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
