using System.IO;
using System.Xml.Serialization;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.ConfigurableFactoryMethod
{
    /// <summary>
    /// Implements the IOrderSerializer interface. 
    /// Uses the Xml serializer to transform the Order object into a string.
    /// </summary>
    public class OrderXmlSerializer: IOrderSerializer
    {
        /// <summary>
        /// Serializes the given order using the standard .NET Xml Serializer
        /// </summary>
        /// <param name="order">The order</param>
        /// <returns>The serialized order</returns>
        public string Serialize(Order order)
        {
            string result = null;
            var serializer = new XmlSerializer(typeof(Order));
            using (var stringWriter = new StringWriter())
            {
                serializer.Serialize(stringWriter, order);
                result = stringWriter.ToString();
            }

            return result;
        }
    }
}
