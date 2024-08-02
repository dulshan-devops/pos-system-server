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
        public int DepartmentId { get; set; }
        public string CategoryId { get; set; }
        public int SupplierId { get; set; }
        public string CostPrice { get; set; }
        public string SellingPrice { get; set; }
        public string WholesalePrice { get; set; }
        public string MarkedPrice { get; set; }
        public string Warranty { get; set; }
        public string Desc { get; set; }
        public string Unit { get; set; }

        //public Department Department { get; set; }
        //public Catergory Category { get; set; }
        //public Supplier Supplier { get; set; }
    }
}
