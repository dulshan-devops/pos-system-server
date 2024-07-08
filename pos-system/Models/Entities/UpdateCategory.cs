namespace pos_system.Models.Entities
{
    public class UpdateCategory
    {
        public int CategoryId { get; set; }
        public required string Name { get; set; }
        public required string Desc { get; set; }
    }
}
