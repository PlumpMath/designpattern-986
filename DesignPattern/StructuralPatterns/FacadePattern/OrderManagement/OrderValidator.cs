using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.FacadePattern.OrderManagement
{
    /// <summary>
    /// Validator for Orders
    /// </summary>
    public class OrderValidator
    {
        /// <summary>
        /// Checks if the order is valid.
        /// The quantity of the ordered article has to be more than 0 and less than 10000.
        /// </summary>
        /// <param name="order">The order</param>
        /// <returns>True, if order is valid</returns>
        public static bool IsValidOrder(Order order)
        {
            bool isValid = true;
            if (order.Quantity < 1 || order.Quantity > 10000)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
