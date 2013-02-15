using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.ConfigurableFactoryMethod
{
    public class OrderXmlSerializer: IOrderManagement
    {
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
