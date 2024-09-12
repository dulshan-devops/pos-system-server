using System.Text.Json.Serialization;

namespace pos_system.Models.Entities
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public required int SupplierId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public DateOnly DeliveryDate { get; set; }

        [JsonIgnore]
        public Supplier? Supplier { get; set; }

        [JsonIgnore]
        public ICollection<PurchaseOrderItems> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItems>();
    }
}
