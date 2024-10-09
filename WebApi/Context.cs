using Microsoft.EntityFrameworkCore;

using WebApi.Models;

namespace WebApi
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=WebApiSokol;Username=postgres;Password=123");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(x => x.TypeProduct)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.TypeId);

            modelBuilder.Entity<Order>()
             .HasOne(x => x.Product)
             .WithMany(x => x.Orders)
             .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<Order>()
           .HasOne(x => x.User)
           .WithMany(x => x.Orders)
           .HasForeignKey(x => x.UserId);


            List<TypeProduct> typeProducts = new List<TypeProduct>()
            {
                  new() {
                    Id = Guid.NewGuid(),
                    Name = "Товар"
                },
                  new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Услуга"
                },
            };

            modelBuilder.Entity<TypeProduct>().HasData(typeProducts);
        
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TypeProduct> TypeProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<News> News { get; set; }
    }
}
