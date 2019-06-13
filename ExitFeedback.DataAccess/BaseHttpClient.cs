using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExitFeedback.DataAccess
{
    public class BaseHttpClient : IHttpClient<Empleado>
    {
        private readonly HttpClient _httpClient;

        public BaseHttpClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Empleado> Get(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(string.Format("https://localhost:44370/api/employee/{0}", id));

            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();
            Empleado emp = JsonConvert.DeserializeObject<Empleado>(jsonString);
            return emp;

        }
    }
}
