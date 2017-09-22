using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XFWebApi.Context;
using XFWebApi.Models;

namespace XFWebApi.Controllers
{
    public class ValuesController : ApiController
    {
       EmployeeContext context=new EmployeeContext();
        // GET api/values
        public List<Employee> Get()
        {
            var allemployees = context.Employees.ToList();

            return allemployees;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post(Employee employee)
        {
            if (employee == null)
            {
            employee=new Employee()
            {
                FullName = "Ajit Pawar",
                Email = "ajp@gmail.com",
                Phone = "7620089612",
                Salary = 10000.00
            };
            }
            context.Employees.Add(employee);
            context.SaveChanges();
            
        }

        // PUT api/values/5
        public void Put(int id, Employee employee)
        {
            employee = new Employee()
            {
                FullName = "Ajay Pawar",
                Email = "ajitp@gmail.com",
                Phone = "7620089613",
                Salary = 10001.00
            };
            var employeedetails = context.Employees.Single(x => x.EmployeeId == id);
            if (employeedetails != null)
            {
                employeedetails.FullName = employee.FullName;
                employeedetails.Email = employee.Email;
                employeedetails.Phone = employee.Phone;
                employeedetails.Salary = employee.Salary;
                context.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var employeedetails = context.Employees.Single(x => x.EmployeeId == id);

            if (employeedetails != null)
            {
                context.Employees.Remove(employeedetails);
                context.SaveChanges();
            }
        }
    }
}
