using System.Text.Json.Serialization;

namespace pos_system.Models.Entities
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public required int TransactionCode { get; set; }
        public required int TransactionTypeId { get; set; }
        public required int Discount { get; set; }
        public required DateTime Date { get; set; }
        
        [JsonIgnore]
        public TransactionType? TransactionType { get; set; }
        
        [JsonIgnore]
        public ICollection<TransactionItem> TransactionItem { get; set; } = new List<TransactionItem>();

    }

}