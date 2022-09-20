using Insurance.ApplicationCore.Interfaces;
using Insurance.Bussiness;
using Insurance.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTest
{
    [TestClass]
    public class CustomerTest
    {
        private readonly Mock<ICustomerRepository> _customerRepository;

        public CustomerTest()
        {
            _customerRepository = new Mock<ICustomerRepository>();
        }
        [TestMethod]
        public void ShouldReturnCustomer()
        {
            Customer employee = new Customer()
            {
                FirstName ="Hasitha",
                LastName ="De Silva",
                PolicyNumber="1234567",
                MemberCardNumber="0987665",
                DataOfBirth ="01-06-1990"
            };

            string policyNumber = "1234567";
            string memberCardNumber = "0987665";
            _customerRepository.Setup(x => x.GetCustomer(policyNumber,memberCardNumber)).Returns(employee);
            var customerService = new CustomerService(_customerRepository.Object);
            var customer = customerService.GetCustomer(policyNumber, memberCardNumber);
            Assert.IsTrue(customer.FirstName == "Hasitha");
            Assert.IsTrue(customer.PolicyNumber == "1234567");
        }
        [TestMethod]
        public void ShouldReturnCustomerByPolicyId()
        {
            Customer employee = new Customer()
            {
                FirstName = "Nethmi",
                LastName = "De Costa",
                PolicyNumber = "1234567",
                MemberCardNumber = "0987665",
                DataOfBirth = "01-06-1990"
            };

            string policyNumber = "1234567";
            _customerRepository.Setup(x => x.GetCustomer(policyNumber)).Returns(employee);
            var customerService = new CustomerService(_customerRepository.Object);
            var customer = customerService.GetCustomer(policyNumber);
            Assert.IsTrue(customer.FirstName == "Nethmi");
            Assert.IsTrue(customer.PolicyNumber == "1234567");
        }
    }
}
