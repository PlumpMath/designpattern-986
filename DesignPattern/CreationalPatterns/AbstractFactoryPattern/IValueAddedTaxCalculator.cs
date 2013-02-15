using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.AbstractFactoryPattern
{
    public interface IValueAddedTaxCalculator
    {
        decimal CalculateGrossPrice(decimal netPrice);
    }
}
