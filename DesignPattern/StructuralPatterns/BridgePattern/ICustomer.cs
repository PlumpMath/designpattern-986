using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.BridgePattern
{
    /// <summary>
    /// Interface of the customer class
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// Gets or sets the customer id
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the customer first name
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the customer last name
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Gets or sets the customer address
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// Gets or sets the customer post code
        /// </summary>
        string PostCode { get; set; }

        /// <summary>
        /// Gets or sets the customer city
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// Bridged method which sets the name of the customer
        /// </summary>
        /// <param name="firstName">The first name</param>
        /// <param name="lastName">The last name</param>
        void SetName(string firstName, string lastName);

        /// <summary>
        /// Bridged method which sets the address of the customer
        /// </summary>
        /// <param name="address">The street</param>
        /// <param name="postCode">The post code</param>
        /// <param name="city">The city</param>
        void SetAddress(string address, string postCode, string city);
    }
}
