﻿using Newtonsoft.Json;
using pos_desktop_app.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace pos_desktop_app.services
{
    public class ProductService
    {
        private HttpClient _httpClient;

        public ProductService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(Properties.Settings.Default.ApiBaseUrl) // Replace with your actual API base URL
            };
        }

        public async Task<HttpResponseMessage> getProducts()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("/api/Product");
            return response;
        }

        public async Task<HttpResponseMessage> saveProduct(Product product , int warrantyPeriod)
        {
            var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"/api/Product/{warrantyPeriod}", content);
            return response;
        }

        public async Task<HttpResponseMessage> updateProduct(Product product)
        {
            var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PutAsync($"/api/Product?id={product.ProductId}", content);
            //Console.WriteLine(category);
            return response;
        }

        public async Task<HttpResponseMessage> deleteProduct(Product product)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"/api/Product?id={product.ProductId}");
            return response;
        }
    }
}
