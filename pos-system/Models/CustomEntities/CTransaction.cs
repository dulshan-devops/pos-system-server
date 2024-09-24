using pos_system.Models.Entities;
using System.Text.Json.Serialization;


namespace pos_system.Models.CustomEntities
{
    public class CTransaction
    {
        public required int TransactionCode { get; set; }
        public required int Discount { get; set; }
        public required DateTime Date { get; set; }
        public required List<CTransactionItem> Items { get; set; }
    }
}
