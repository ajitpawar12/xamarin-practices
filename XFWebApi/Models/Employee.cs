using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XFWebApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }
    }
}