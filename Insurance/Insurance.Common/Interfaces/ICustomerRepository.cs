using Insurance.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.ApplicationCore.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(string policyID);

        Customer GetCustomer(string policyID, string memberCardNumber);
    }
}
