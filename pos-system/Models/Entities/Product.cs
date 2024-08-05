using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace pos_system.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string ProductCode { get; set; }
        public required string ProductName { get; set; }
        public required int DepartmentId { get; set; }
        public required int CategoryId { get; set; }
        public required int SupplierId { get; set; }

        [Precision(18, 2)]
        public required decimal CostPrice { get; set; }
        [Precision(18, 2)]
        public required decimal SellingPrice { get; set; }
        [Precision(18, 2)]
        public decimal? WholesalePrice { get; set; }
        [Precision(18, 2)]
        public decimal? MarkedPrice { get; set; }
        public required int Warranty { get; set; }
        public string? Desc { get; set; }
        public string? Unit { get; set; }

        [JsonIgnore]
        public Department? Department { get; set; }
        [JsonIgnore]
        public Category? Category { get; set; }
        [JsonIgnore]
        public Supplier? Supplier { get; set; }
    }
}
