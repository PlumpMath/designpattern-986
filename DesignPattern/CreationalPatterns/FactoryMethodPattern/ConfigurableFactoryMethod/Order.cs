using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.CreationalPatterns.FactoryMethodPattern.ConfigurableFactoryMethod
{
    /// <summary>
    /// Order DTO (Data Transfer Object) which holds the data
    /// </summary>
    [Serializable]
    [DataContract]
    public class Order
    {
        /// <summary>
        /// Gets or sets the Order Id
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Order Name
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the order has been placed
        /// </summary>
        [DataMember]
        public DateTime Placed { get; set; }
    }
}
