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
                BaseAddress = new Uri("https://nova-pos-system-api.azurewebsites.net") // Replace with your actual API base URL
            };
        }

        public async Task<HttpResponseMessage> getCategories()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("/api/Category");
            return response;
        }

        public async Task<HttpResponseMessage> saveCategories(string cat, string desc)
        {
            var catData = new { name = cat, desc = desc };
            var content = new StringContent(JsonConvert.SerializeObject(catData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("/api/Category", content);
            return response;
        }

        public async Task<HttpResponseMessage> updateCategory(Catergory category)
        {
            var catData = new { categoryId = category.categoryId, name = category.name, desc = category.desc };
            var content = new StringContent(JsonConvert.SerializeObject(catData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PutAsync($"/api/Category?id={category.categoryId}", content);
            //Console.WriteLine(category);
            return response;
        }

        public async Task<HttpResponseMessage> deleteCategory(Catergory category)
        {
            var catData = new { categoryId = category.categoryId, name = category.name, desc = category.desc };
            var content = new StringContent(JsonConvert.SerializeObject(catData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.DeleteAsync($"/api/Category?id={category.categoryId}");
            return response;
        }
    }
}
