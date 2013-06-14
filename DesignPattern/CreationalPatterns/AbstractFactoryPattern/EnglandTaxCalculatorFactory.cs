using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.AbstractFactoryPattern
{
    /// <summary>
    /// Factory for tax calculations in England. This class could return multiple calculators for different use-cases.
    /// </summary>
    public class EnglandTaxCalculatorFactory: ITaxCalculatorFactory
    {
        /// <summary>
        /// Creates a value added tax calculator for England
        /// </summary>
        /// <returns>The implementation for England value added tax calculation</returns>
        public IValueAddedTaxCalculator CreateValueAddedTaxCalculator()
        {
            return new EnglandValueAddedTaxCalculator();
        }
    }
}
