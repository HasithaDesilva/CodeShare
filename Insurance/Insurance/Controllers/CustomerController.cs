using Insurance.ApplicationCore.Interfaces;
using Insurance.ApplicationCore.Models;
using Insurance.ApplicationCore.Utils;
using Insurance.Common.Models;
using Insurance.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance.Controllers
{
    [Route("api")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        [Route("member")]
        public IActionResult GetMember(string policyID, string memberCardNumber)
        {
            GenericResponse<Customer> genericResponse = new GenericResponse<Customer>();
            if (!CommonValidator.ValidateCharacter(policyID))
            {
                genericResponse.ErrorMessage = "Invalid policy id";
                genericResponse.Status = "Fail";
                return Ok(genericResponse);
            }
            if (!string.IsNullOrEmpty(memberCardNumber))
            {
                if (!CommonValidator.ValidateCharacter(memberCardNumber))
                {
                    genericResponse.ErrorMessage = "Invalid member CardNumber";
                    genericResponse.Status = "Fail";
                    return Ok(genericResponse);
                }
                genericResponse.Data = _customerService.GetCustomer(policyID, memberCardNumber);
            }
            else
            {
                genericResponse.Data = _customerService.GetCustomer(policyID);
            }

            genericResponse.Status = "Success";
            if (genericResponse.Data == null)
            {
                genericResponse.ErrorMessage = "Member not found";
                genericResponse.Status = "Fail";
            }
           
            return Ok(genericResponse);
        }
    }
}
