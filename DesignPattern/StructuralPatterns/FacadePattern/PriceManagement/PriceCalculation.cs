using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.FacadePattern.PriceManagement
{
    public class PriceCalculation
    {
        private Dictionary<string, decimal> _priceMap = new Dictionary<string, decimal>()
        {
             { "A100", 10.0m },
             { "A200", 50.0m },
             { "A123", 440.0m },
             { "A400", 13.6m },
             { "B223", 12.1m },
             { "C123", 79.55m }
        };

        public decimal CalculatePrice(string articleId, int quantity)
        {
            var result = -1m;
            if (_priceMap.ContainsKey(articleId))
            {
                result = _priceMap[articleId] * quantity;
            }
            return result;
        }
    }
}
