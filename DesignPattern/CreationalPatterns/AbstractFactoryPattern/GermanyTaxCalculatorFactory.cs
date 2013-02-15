using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.AbstractFactoryPattern
{
    public class GermanyTaxCalculatorFactory: ITaxCalculatorFactory
    {
        public IValueAddedTaxCalculator CreateValueAddedTaxCalculator()
        {
            return new GermanyValueAddedTaxCalculator();
        }
    }
}
