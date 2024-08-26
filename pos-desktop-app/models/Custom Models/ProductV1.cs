using Newtonsoft.Json;
using pos_system.Models.Entities;

namespace pos_system.Models.Custom_Entities
{
    public class ProductV1
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal? WholesalePrice { get; set; }
        public string Desc { get; set; }
        public string Unit { get; set; }
    }
}
