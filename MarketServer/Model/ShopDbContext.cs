using Microsoft.EntityFrameworkCore;

namespace Shop.Entity
{
    class ShopDbContext:DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Rebate> Rebates { get; set; }
        public DbSet<User> users { get;set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
