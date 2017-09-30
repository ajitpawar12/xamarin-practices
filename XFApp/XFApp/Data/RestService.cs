using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XFApp.Models;

namespace XFApp.Data
{
    public class RestService:IRestService
    {
        readonly HttpClient _client;
       public static string RestUrl = "http://192.168.0.4:1000/api/values";

        readonly Uri _uri = new Uri(string.Format(RestUrl, string.Empty));

        public RestService()
        {
            _client = new HttpClient();
            _client.MaxResponseContentBufferSize = 256000;
            
        }

        public List<Employee> Values { get; set; }

        public async Task<List<Employee>> GetValues()
        {
            try
            {
                var response = await _client.GetAsync(_uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Values=JsonConvert.DeserializeObject<List<Employee>>(content);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
                throw;
            }
            return Values;
        }

        public Task<IEnumerable<List<Employee>>> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public async Task SaveEmployee(Employee employee)
        {
            try
            {
                var json = JsonConvert.SerializeObject(employee);
                var content= new StringContent(json,Encoding.UTF8,"application/json");
                HttpResponseMessage response = null;

                if (employee != null)
                {
                    response = await _client.PostAsync(_uri, content);
                }
                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"				TodoItem successfully saved.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);

            }
        }

        public Task UpdateEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
