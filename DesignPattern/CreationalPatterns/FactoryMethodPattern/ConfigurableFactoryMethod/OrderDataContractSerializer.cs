using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.ConfigurableFactoryMethod
{
    /// <summary>
    /// Implements the IOrderSerializer interface. 
    /// Uses the data contract serializer to transform the Order object into a string.
    /// </summary>
    public class OrderDataContractSerializer : IOrderSerializer
    {
        /// <summary>
        /// Serializes the given order using the Data Contract Serializer
        /// </summary>
        /// <param name="order">The order</param>
        /// <returns>The serialized order</returns>
        public string Serialize(Order order)
        {
            string result = null;

            var serializer = new DataContractSerializer(typeof(Order));
            using (var memoryStream = new MemoryStream())
            {
                serializer.WriteObject(memoryStream, order);
                result = Encoding.UTF8.GetString(memoryStream.ToArray());
            }

            return result;
        }
    }
}
