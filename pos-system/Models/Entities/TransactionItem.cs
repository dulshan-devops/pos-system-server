using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace pos_system.Models.Entities
{
    public class TransactionItem
    {
        public  int TransactionItemId { get; set; }
        public required int TransactionId { get; set; }
        public required int ProductId { get; set; }
        [Precision(18, 2)]
        public required decimal CostPrice { get; set; }
        [Precision(18, 2)]
        public required decimal SPrice { get; set; }
        [Precision(18, 2)]
        public required decimal WPrice { get; set; }
        public required int Qty { get; set; }

        [Precision(18, 2)]
        public required decimal Discount { get; set; }

        [Precision(18, 2)]
        public required decimal ItemTotal { get; set; }

        [JsonIgnore]
        public Transaction? Transaction { get; set; }

        [JsonIgnore]
        public Product? Product { get; set; }
    }

}