using Insurance.ApplicationCore.Interfaces;
using Insurance.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Infrastructure.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IRepository<Customer> _repository;
     
        public CustomerRepository(IRepository<Customer> repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// This method is used to Get Customer by PolicyID
        /// </summary>
        /// <param name="policyID"></param>
        /// <returns></returns>
        public Customer GetCustomer(string policyID)
        {
            IList<Customer> customerList = _repository.GetAll();

            Customer customer = customerList
                    .AsQueryable()
                    .FirstOrDefault(p => p.PolicyNumber == policyID);
            return customer;
        }
        /// <summary>
        /// This method is used to Get Customer by policyId and memberCardNumber
        /// </summary>
        /// <param name="policyID"></param>
        /// <param name="memberCardNumber"></param>
        /// <returns></returns>
        public Customer GetCustomer(string policyID, string memberCardNumber)
        {
            IList<Customer> customerList = _repository.GetAll();

            Customer customer = customerList
                    .AsQueryable()
                    .FirstOrDefault(p => p.PolicyNumber == policyID
                                      && p.MemberCardNumber == memberCardNumber);
            return customer;
        }
    }
}
