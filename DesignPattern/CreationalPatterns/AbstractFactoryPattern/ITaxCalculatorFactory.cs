using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.AbstractFactoryPattern
{
    /// <summary>
    /// Base Interface of the Abstract Factory "Tax Calculator".
    /// For the sake of simplification it just contains a single factory method.
    /// In a more complex scenario this Abstract Factory would contain 
    /// multiple factory methods which fulfil different use-cases.
    /// </summary>
    public interface ITaxCalculatorFactory
    {
        /// <summary>
        /// Creates a value added tax calculator for different countries
        /// </summary>
        /// <returns>Value Added Tax Calculator</returns>
        IValueAddedTaxCalculator CreateValueAddedTaxCalculator();
    }
}
