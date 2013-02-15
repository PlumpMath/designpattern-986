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
    public class OrderDataContractSerializer : IOrderManagement
    {
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
