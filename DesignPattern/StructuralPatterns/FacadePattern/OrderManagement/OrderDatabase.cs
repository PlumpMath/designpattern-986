using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.FacadePattern.OrderManagement
{
    public class OrderStorage
    {
        public static bool PlaceOrder(Order order)
        {
            // Store Order for further processing
            return true;
        }
    }
}
