using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.FacadePattern.OrderManagement
{
    /// <summary>
    /// Order Storage class taking care about persisting the order
    /// </summary>
    public class OrderStorage
    {
        /// <summary>
        /// Dummy implementation which represents the order placing
        /// </summary>
        /// <param name="order">The order to store</param>
        /// <returns>True, if order has been successfully placed</returns>
        public static bool PlaceOrder(Order order)
        {
            // Store Order for further processing
            return true;
        }
    }
}
