using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSTune.DesignPattern.CreationalPatterns.AbstractFactoryPattern;

namespace TSTune.DesignPattern.UnitTests.CreationalPatterns
{
    /// <summary>
    /// Test class for the Abstract Factory Pattern
    /// </summary>
    [TestClass]
    public class AbstractFactoryTest
    {
        /// <summary>
        /// This test shows how the Abstract Factories could be used based on a configuration setting.
        /// In this case the application setting "TaxCountry" is set to Germany 
        /// and a 19 percent taxes should be added to the net price.
        /// </summary>
        [TestMethod]
        public void GermanTaxCalculator_Should_Add19PercentTaxes()
        {
            // Arrange
            var netPrice = 1000m;
            ITaxCalculatorFactory taxCalculatorFactory;
            if (ConfigurationManager.AppSettings["TaxCountry"] == "Germany")
            {
                taxCalculatorFactory = new GermanyTaxCalculatorFactory();
            }
            else
            {
                taxCalculatorFactory = new EnglandTaxCalculatorFactory();
            }

            // Act
            var taxCalculator = taxCalculatorFactory.CreateValueAddedTaxCalculator();
            var grossPrice = taxCalculator.CalculateGrossPrice(netPrice);
            
            // Assert
            Assert.IsInstanceOfType(taxCalculator, typeof(GermanyValueAddedTaxCalculator));
            Assert.AreEqual(1190, grossPrice);
        }
    }
}
