using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using pos_desktop_app;
using pos_desktop_app.models;
using System.Security.Cryptography;

namespace pos_desktop_app
{
    public class CategoryService
    {
        private HttpClient _httpClient;

        public CategoryService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(Properties.Settings.Default.ApiBaseUrl) // Replace with your actual API base URL
            };
        }

        public async Task<HttpResponseMessage> getCategories()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("/api/Category");
            return response;
        }

        public async Task<HttpResponseMessage> saveCategories(string cat, string desc)
        {
            var catData = new { Name = cat, Desc = desc };
            var content = new StringContent(JsonConvert.SerializeObject(catData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("/api/Category", content);
            return response;
        }

        public async Task<HttpResponseMessage> updateCategory(Catergory category)
        {
            var catData = new { CategoryId = category.CategoryId, Name = category.Name, desc = category.Desc };
            var content = new StringContent(JsonConvert.SerializeObject(catData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PutAsync($"/api/Category?id={category.CategoryId}", content);
            //Console.WriteLine(category);
            return response;
        }

        public async Task<HttpResponseMessage> deleteCategory(Catergory category)
        {
            var catData = new { CategoryId = category.CategoryId, Name = category.Name, Desc = category.Desc };
            var content = new StringContent(JsonConvert.SerializeObject(catData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.DeleteAsync($"/api/Category?id={category.CategoryId}");
            return response;
        }
    }
}
