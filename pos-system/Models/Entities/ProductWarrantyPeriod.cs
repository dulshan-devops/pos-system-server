using System.Text.Json.Serialization;

namespace pos_system.Models.Entities
{
    public class ProductWarrantyPeriod
    {
        public int Id { get; set; }
        public required int ProductId { get; set; }
        public required int WarrantyPeriod { get; set; }

        [JsonIgnore]
        public Product? Product { get; set; }
    }
}
