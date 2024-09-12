using pos_system.Models.Entities;
using System.Text.Json.Serialization;


namespace pos_system.Models.CustomEntities
{
    public class POrder
    {
        public int SupplierId { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public List<POrderItems> Items { get; set; } = new();

        [JsonIgnore]
        public Supplier? Supplier { get; set; }
    }
}
