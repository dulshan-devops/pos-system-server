using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace pos_system.Models.Entities
{
    public class Customer
    {
        public required int CustomerId { get; set; }
        public required string CustomerName { get; set; }
        public required string Mobile1 { get; set; }
        public required string Mobile2 { get; set; }
        public required string Email { get; set; }
        public required string Address { get; set; }

        [Precision(18, 2)]
        public required decimal CreditLimit { get; set; }

        [Precision(18, 2)]
        public required decimal Credit { get; set; }

        [Precision(18, 2)]
        public required decimal Dedit { get; set; }
        public required string Desc { get; set; }
    }
}
