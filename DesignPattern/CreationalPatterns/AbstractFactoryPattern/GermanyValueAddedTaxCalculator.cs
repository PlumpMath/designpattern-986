using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.AbstractFactoryPattern
{
    /// <summary>
    /// Value added tax calculator for Germany.
    /// Allows to calculate a gross price in Germany based on the given NetPrice.
    /// It adds 19 percent taxes on the net price.
    /// </summary>
    public class GermanyValueAddedTaxCalculator: IValueAddedTaxCalculator
    {
        /// <summary>
        /// Adds 19 percent taxes on the net price.
        /// </summary>
        /// <param name="netPrice">The net price</param>
        /// <returns>The gross price</returns>
        public decimal CalculateGrossPrice(decimal netPrice)
        {
            return netPrice * 1.19m;
        }
    }
}
