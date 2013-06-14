using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.FacadePattern.PriceManagement
{
    /// <summary>
    /// Price Calculation class which looks up the price in a static dictionary.
    /// Multiplies the hard-coded price with the given quantity.
    /// </summary>
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

        /// <summary>
        /// Calculates the price based on the article id and the quantity
        /// </summary>
        /// <param name="articleId">The article id</param>
        /// <param name="quantity">The quantity</param>
        /// <returns>The price of the article</returns>
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
