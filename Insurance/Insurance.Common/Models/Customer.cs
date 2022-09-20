using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Common.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MemberCardNumber { get; set; }
        public string PolicyNumber { get; set; }
        public string DataOfBirth { get; set; }
    }
}
