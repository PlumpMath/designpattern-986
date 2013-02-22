using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.FacadePattern.OrderManagement
{
    public class OrderValidator
    {
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
