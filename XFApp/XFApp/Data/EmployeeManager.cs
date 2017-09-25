using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFApp.Models;

namespace XFApp.Data
{
    public class EmployeeManager
    {
        readonly IRestService _restService;

        public EmployeeManager(IRestService restService)
        {
            _restService = restService;
        }

        public Task<List<Employee>> GetTaskAsync()
        {
            var result =_restService.GetValues();
            return result;
        }
    }
}
