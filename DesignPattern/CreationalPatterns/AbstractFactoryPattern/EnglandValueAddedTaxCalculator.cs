using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.AbstractFactoryPattern
{
    public class EnglandValueAddedTaxCalculator: IValueAddedTaxCalculator
    {
        public decimal CalculateGrossPrice(decimal netPrice)
        {
            return netPrice * 1.20m;
        }
    }
}
