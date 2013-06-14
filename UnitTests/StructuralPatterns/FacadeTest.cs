using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.StructuralPatterns.FacadePattern;

namespace TSTune.DesignPattern.UnitTests.StructuralPatterns
{
    /// <summary>
    /// Test class for the Facade Pattern
    /// </summary>
    [TestClass]
    public class FacadeTest
    {
        /// <summary>
        /// Calls the facade with correct parameters.
        /// Order should pass the validation process successfully.
        /// </summary>
        [TestMethod]
        public void Order_ShouldBe_PlacedSuccessfully()
        {
            OrderApplicatoinServiceFacadeCall("A200", 1, true);
        }

        /// <summary>
        /// Order will not be placed successfullly because a negative quantity is handed over 
        /// and the Order Validation process fails, which is called in the Facade implementation
        /// </summary>
        [TestMethod]
        public void OrderWithNegativeQuantity_ShouldReturn_InvalidFlag()
        {
            OrderApplicatoinServiceFacadeCall("A200", -2392, false);
        }

        /// <summary>
        /// Order will not be placed because the given article number is invalid.
        /// Therefore, no price is found and the placement process fails
        /// </summary>
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
