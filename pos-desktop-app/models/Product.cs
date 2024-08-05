using Newtonsoft.Json;
using pos_system.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace pos_desktop_app.models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int DepartmentId { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal? WholesalePrice { get; set; }
        public decimal? MarkedPrice { get; set; }
        public int Warranty { get; set; }
        public string Desc { get; set; }
        public string Unit { get; set; }

        //public Department Department { get; set; }
        //public Catergory Category { get; set; }
        //public Supplier Supplier { get; set; }
    }
}
