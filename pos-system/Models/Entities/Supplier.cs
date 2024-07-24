using Microsoft.EntityFrameworkCore;

namespace pos_system.Models.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public required string SupplierCode { get; set; }
        public required string SupplierName { get; set; }
        public required string ContactPerson { get; set; }
        public required string Email { get; set; }
        public required string Mobile1 { get; set; }
        public required string Mobile2 { get; set; }
        public required string Address { get; set; }

        [Precision(18, 2)]
        public required decimal CreditLimit { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
