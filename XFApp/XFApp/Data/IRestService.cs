using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFApp.Models;

namespace XFApp.Data
{
    public interface IRestService
    {
        Task<List<Employee>> GetValues();

        Task<IEnumerable<List<Employee>>> GetAllEmployee();

        Task SaveEmployee(Employee employee);

        Task UpdateEmployee(int id, Employee employee);
    }
}
