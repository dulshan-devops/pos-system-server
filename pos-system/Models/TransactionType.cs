
namespace pos_system.Models.Entities
{
    public class TransactionType
    {
        public int TransactionTypeId { get; set; }
        public required string TransactionTypeName { get; set; }
        public required string Desc { get; set; }
    }

}
