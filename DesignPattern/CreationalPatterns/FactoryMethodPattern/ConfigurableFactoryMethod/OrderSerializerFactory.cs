using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.ConfigurableFactoryMethod
{
    public class OrderSerializerFactory
    {
        public static IOrderManagement GetSerializer()
        {
            IOrderManagement result = null;

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
