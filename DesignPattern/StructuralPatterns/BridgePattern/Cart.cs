using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.BridgePattern
{
    /// <summary>
    /// This class shows the Bridge pattern. The cart is just bridging the Customer calls.
    /// The SetCustomerName and SetDeliveryAddress are forwarded to the Customer Entity which implements it.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Constructor which also creates the Customer class which is owned by this instance.
        /// </summary>
        public Cart()
        {
            Customer = new Customer();
        }

        /// <summary>
        /// Gets or sets the Id of the cart
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the cart name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the customer entity
        /// </summary>
        public ICustomer Customer { get; set; }

        /// <summary>
        /// This call is bridged/forwarded to the underlying customer entity.
        /// It sets the name of the customer.
        /// </summary>
        /// <param name="firstName">The first name of the customer</param>
        /// <param name="lastName">The last name of the customer</param>
        public void SetCustomerName(string firstName, string lastName)
        {
            Customer.SetName(firstName, lastName);
        }
        /// <summary>
        /// This call is bridged/forwarded to the underlying customer entity.
        /// It sets the address of the customer.
        /// </summary>
        /// <param name="address">The customers street</param>
        /// <param name="postCode">The customers post code</param>
        /// <param name="city">The customers city</param>
        public void SetDeliveryAddress(string address, string postCode, string city)
        {
            Customer.SetAddress(address, postCode, city);
        }
    }
}
