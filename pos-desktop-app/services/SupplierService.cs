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
using pos_system.Models.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using pos_desktop_app.views;

namespace pos_desktop_app
{
    public class SupplierService
    {
        private HttpClient _httpClient;

        public SupplierService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(Properties.Settings.Default.ApiBaseUrl) // Replace with your actual API base URL
            };
        }

        public async Task<HttpResponseMessage> getSuppliers()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("/api/Supplier");
            return response;
        }

        public async Task<HttpResponseMessage> saveSupplier(string supCode, string supName, string contactPerson, string email, string mobile1, string mobile2, string address, decimal creditLimit)
        {
            var supData = new
            {
                SupplierCode = supCode,
                SupplierName = supName,
                ContactPerson = contactPerson,
                Email = email,
                Mobile1 = mobile1,
                Mobile2 = mobile2,
                Address = address,
                CreditLimit = creditLimit
            };

            var content = new StringContent(JsonConvert.SerializeObject(supData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("/api/Supplier", content);
            return response;
        }

        public async Task<HttpResponseMessage> updateSupplier(Supplier supplier)
        {
            var supData = new {
                SupplierCode = supplier.SupplierCode,
                SupplierName = supplier.SupplierName,
                ContactPerson = supplier.ContactPerson,
                Email = supplier.Email,
                Mobile1 = supplier.Mobile1,
                Mobile2 = supplier.Mobile2,
                Address = supplier.Address,
                CreditLimit = supplier.CreditLimit
            };

            var content = new StringContent(JsonConvert.SerializeObject(supData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PutAsync($"/api/Supplier?id={supplier.SupplierId}", content);
            //Console.WriteLine(category);
            return response;
        }

        public async Task<HttpResponseMessage> deleteSupplier(Supplier supplier)
        {
            var supData = new {
                SupplierCode = supplier.SupplierCode,
                SupplierName = supplier.SupplierName,
                ContactPerson = supplier.ContactPerson,
                Email = supplier.Email,
                Mobile1 = supplier.Mobile1,
                Mobile2 = supplier.Mobile2,
                Address = supplier.Address,
                CreditLimit = supplier.CreditLimit
            };

            var content = new StringContent(JsonConvert.SerializeObject(supData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.DeleteAsync($"/api/Supplier?id={supplier.SupplierId}");
            return response;
        }
    }
}
