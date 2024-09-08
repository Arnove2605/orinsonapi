using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<ContactClass> contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactClass>().ToTable("contacts");
        }
    }
    
}
