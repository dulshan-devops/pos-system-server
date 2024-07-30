using System.Text.Json.Serialization;

namespace pos_system.Models.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public required string DepartmentName { get; set; }
        public string? Desc { get; set; }
        [JsonIgnore]

        public ICollection<Product>? Products { get; set; } = new List<Product>();
    }
}
