using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace pos_system.Models.Entities
{
    public class PurchaseOrderItems
    {
        public int Id { get; set; }
        public required int PurchaseOrderId { get; set; }
        public required int ProductId { get; set; }

        [Precision(18, 2)]
        public required decimal CostPrice { get; set; }

        [Precision(18, 2)]
        public required decimal Quantity { get; set; }

        [Precision(18, 2)]
        public required decimal ItemTotalAmount { get; set; }

        [JsonIgnore]
        public Product? Product { get; set; }
    }
}
