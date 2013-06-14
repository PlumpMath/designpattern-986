using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.AbstractFactoryPattern
{
    /// <summary>
    /// Interface for the Factory Method.
    /// Defines the methods of a value added tax calculator.
    /// </summary>
    public interface IValueAddedTaxCalculator
    {
        /// <summary>
        /// Adds x percent of taxes on the given net price.
        /// </summary>
        /// <param name="netPrice">The net price</param>
        /// <returns>The gross price</returns>
        decimal CalculateGrossPrice(decimal netPrice);
    }
}
