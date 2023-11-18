using Microsoft.EntityFrameworkCore;

namespace WebApi.Models.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Order> orders { get;set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Product> products { get; set; }    
        public DbSet<Category> categories { get; set; } 
        public DbSet<Rate> rate { get; set; }
    }
}
