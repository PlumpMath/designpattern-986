using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSTune.DesignPattern.StructuralPatterns.BridgePattern
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string Address { get; set; }
        string PostCode { get; set; }
        string City { get; set; }

        void SetName(string firstName, string lastName);
        void SetAddress(string address, string postCode, string city);
    }
}
