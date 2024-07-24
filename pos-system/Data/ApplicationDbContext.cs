using Microsoft.EntityFrameworkCore;
using pos_system.Models.Entities;

namespace pos_system.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
