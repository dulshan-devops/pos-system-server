namespace pos_system.Models.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierCode{ get; set; }
        public string SupplierName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Address { get; set; }
        public decimal CreditLimit { get; set; }
    }
}
