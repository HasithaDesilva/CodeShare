using Insurance.ApplicationCore.Interfaces;
using Insurance.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Bussiness
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        
        /// <summary>
        /// This method is used to Get Customer details by policyID
        /// </summary>
        /// <param name="policyID"></param>
        /// <returns></returns>
        public Customer GetCustomer(string policyID)
        {
            return _customerRepository.GetCustomer(policyID);
        }
        /// <summary>
        /// This method is used to Get Customer details by policyId and MemberCardNumber
        /// </summary>
        /// <param name="policyID"></param>
        /// <param name="memberCardNumber"></param>
        /// <returns></returns>
        public Customer GetCustomer(string policyID, string memberCardNumber)
        {
            return _customerRepository.GetCustomer(policyID, memberCardNumber);
        }
    }
}
