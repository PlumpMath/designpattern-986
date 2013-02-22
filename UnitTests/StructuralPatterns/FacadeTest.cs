using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.StructuralPatterns.FacadePattern;

namespace TSTune.DesignPattern.UnitTests.StructuralPatterns
{
    [TestClass]
    public class FacadeTest
    {
        [TestMethod]
        public void Order_ShouldBe_PlacedSuccessfully()
        {
            OrderApplicatoinServiceFacadeCall("A200", 1, true);
        }

        [TestMethod]
        public void OrderWithNegativeQuantity_ShouldReturn_InvalidFlag()
        {
            OrderApplicatoinServiceFacadeCall("A200", -2392, false);
        }

        [TestMethod]
        public void OrderWithInvalidArticle_ShouldReturn_InvalidFlag()
        {
            OrderApplicatoinServiceFacadeCall("Tes2s3", 2, false);
        }

        private static void OrderApplicatoinServiceFacadeCall(string articleName, int quantity, bool expectedResult)
        {
            // Arrange 
            OrderApplicationServiceFacade facade = new OrderApplicationServiceFacade();
            // Act 
            bool actual = facade.PlaceOrder(articleName, quantity);
            // Assert 
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
