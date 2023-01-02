using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCfullDemo2023.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public Int64 PhoneNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PinCode { get; set; }
        public string Country { get; set; }
    }
}