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
    [TestClass]
    public class AbstractFactoryTest
    {
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
