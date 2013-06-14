using System.Configuration;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.ConfigurableFactoryMethod
{
    /// <summary>
    /// Class which contains a simple factory method 
    /// which picks the serializer based on a configuration setting
    /// </summary>
    public class OrderSerializerFactory
    {
        /// <summary>
        /// This Factory Method hides the implementation details of the actual serializes. 
        /// It simply returns an interface with a serialize method.
        /// Based on the AppSettings configuration setting "OrderSerializer" 
        /// one of the available serializers (xml or data contract) is returned.
        /// 
        /// The configuration setting "OrderSerializer" can have two values "XmlSerializer" or "DataContractSerializer". 
        /// By default the "DataContractSerializer" is taken.
        /// </summary>
        /// <returns></returns>
        public static IOrderSerializer GetSerializer()
        {
            IOrderSerializer result = null;

            if (ConfigurationManager.AppSettings["OrderSerializer"] == "XmlSerializer")
            {
                result = new OrderXmlSerializer();
            }
            else
            {
                result = new OrderDataContractSerializer();
            }

            return result;
        }
    }
}
