using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.BridgePattern
{
    /// <summary>
    /// The Cart methods SetCustomerName and SetDeliveryAddress are forwarded to the Customer Entity which implements it.
    /// </summary>
    public class Cart
    {
        public Cart()
        {
            Customer = new Customer();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICustomer Customer { get; set; }

        public void SetCustomerName(string firstName, string lastName)
        {
            Customer.SetName(firstName, lastName);
        }
        public void SetDeliveryAddress(string address, string postCode, string city)
        {
            Customer.SetAddress(address, postCode, city);
        }
    }
}
