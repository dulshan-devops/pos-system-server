﻿using System.Text.Json.Serialization;

namespace pos_system.Models.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public required string Name { get; set; }
        public required string Desc { get; set; }

        [JsonIgnore]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
