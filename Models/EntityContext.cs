using Microsoft.EntityFrameworkCore;

namespace bicycles.Models
{
    public class EntityContext : DbContext 
    {
        public EntityContext(DbContextOptions<EntityContext> options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Bike> bikes { get; set; }
        
    }
} 






