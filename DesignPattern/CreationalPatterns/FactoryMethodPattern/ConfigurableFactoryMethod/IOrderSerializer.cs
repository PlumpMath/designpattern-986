using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.ConfigurableFactoryMethod
{
    /// <summary>
    /// Interface which abstracts the used serializer
    /// </summary>
    public interface IOrderSerializer
    {
        /// <summary>
        /// Serializes the given order
        /// </summary>
        /// <param name="order">The order</param>
        /// <returns>The order as a string</returns>
        string Serialize(Order order);
    }
}
