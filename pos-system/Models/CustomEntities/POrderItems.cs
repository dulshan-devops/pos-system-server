using pos_system.Models.Entities;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace pos_system.Models.CustomEntities
{
    public class POrderItems
    {
        public int ProductId { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Quantity { get; set; }

        [JsonIgnore]
        public decimal ItemTotalAmount { get; set; }

        [JsonIgnore]
        public Product? Product { get; set; }
    }
}
