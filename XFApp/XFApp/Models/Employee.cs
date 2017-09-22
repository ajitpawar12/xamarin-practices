using System;
using System.Collections.Generic;
using System.Linq;

namespace XFApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }
        public string ImageUrl { get; set; }
    }
}