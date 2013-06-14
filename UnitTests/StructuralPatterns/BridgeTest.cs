using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.StructuralPatterns.BridgePattern;

namespace TSTune.DesignPattern.UnitTests.StructuralPatterns
{
    /// <summary>
    /// Test class for the Bridge pattern
    /// </summary>
    [TestClass]
    public class BridgeTest
    {
        /// <summary>
        /// This test uses the Cart bridge class to store Customer data.
        /// After that it validates if the Customer received the data.
        /// </summary>
        [TestMethod]
        public void Customer_Should_ContainDataSetInCart()
        {
            // Arrange
            string firstName = "Thomas";
            string lastName = "S";
            string address = "Example Address 12";
            string postCode = "12345";
            string city = "Munich";

            Cart cart = new Cart();

            // Act
            cart.SetCustomerName(firstName, lastName);
            cart.SetDeliveryAddress(address, postCode, city);

            var customer = cart.Customer;

            // Assert
            Assert.AreEqual(firstName, customer.FirstName);
            Assert.AreEqual(lastName, customer.LastName);

            Assert.AreEqual(address, customer.Address);
            Assert.AreEqual(postCode, customer.PostCode);
            Assert.AreEqual(city, customer.City);
        }
    }
}
