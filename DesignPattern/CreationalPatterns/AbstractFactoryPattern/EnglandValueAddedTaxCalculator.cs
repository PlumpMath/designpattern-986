using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.AbstractFactoryPattern
{
    /// <summary>
    /// Value added tax calculator for England.
    /// Allows to calculate a gross price in England based on the given NetPrice.
    /// It adds 20 percent taxes on the net price.
    /// </summary>
    public class EnglandValueAddedTaxCalculator: IValueAddedTaxCalculator
    {
        /// <summary>
        /// Adds 20 percent taxes on the net price.
        /// </summary>
        /// <param name="netPrice">The net price</param>
        /// <returns>The gross price</returns>
        public decimal CalculateGrossPrice(decimal netPrice)
        {
            return netPrice * 1.20m;
        }
    }
}
