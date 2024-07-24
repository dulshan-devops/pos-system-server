namespace pos_system.Models.Entities
{
    public class ProductWarranty
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public required decimal WarrantyPeriod { get; set; }

        public Product? Product { get; set; }
    }
}
