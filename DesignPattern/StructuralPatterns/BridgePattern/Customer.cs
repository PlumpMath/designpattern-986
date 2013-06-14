using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.BridgePattern
{
    /// <summary>
    /// This entity is not directly called by the client. 
    /// Instead, the calls to SetName and SetAddress are bridged by the cart class.
    /// </summary>
    public class Customer: ICustomer
    {
        /// <summary>
        /// Gets or sets the customer id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the customer first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the customer last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the customer address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the customer post code
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets the customer city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Bridged method which sets the name of the customer
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        public void SetName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Bridged method which sets the address of the customer
        /// </summary>
        /// <param name="address">The street</param>
        /// <param name="postCode">The post code</param>
        /// <param name="city">The city</param>
        public void SetAddress(string address, string postCode, string city)
        {
            Address = address;
            PostCode = postCode;
            City = city;
        }
    }
}
