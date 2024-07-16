using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace pos_desktop_app.services
{
    public class DepartmentService
    {
        private HttpClient _httpClient;

        public DepartmentService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7038") // Replace with your actual API base URL
            };
        }

        public async Task<HttpResponseMessage> getDepartment()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("/api/Department");
            return response;
        }
    }
}
