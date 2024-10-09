using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

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

            //ЮЗЕРЫ
            List<User> users = new List<User>()
            {
                new()
                {
                    Id= Guid.NewGuid(),
                    IsClient = true,
                    IsProvider = true,
                    FIO = "Фамилия имя отчество",
                    Discount = 20,
                },
                new()
                {

                }
            };

            modelBuilder.Entity<User>().HasData(users);

            //ТОВАРЫ
            List<Product> products = new List<Product>()
            {
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 1,
                    TypeId = typeProducts[0].Id,
                }
            };

            modelBuilder.Entity<Product>().HasData(products);



            //ЗАКАЗЫ
            List<Order> orders = new List<Order>()
            {
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    ProductId = products[0].Id,
                    Sum = 1,
                    UserId = users[0].Id
                }
            };

            modelBuilder.Entity<Order>().HasData(orders);

            List<News> news = new List<News>()
            {
                new()
                {
                    Id= Guid.NewGuid(),
                    Title = "Title1",
                    Created = DateTime.Now,
                    Description = "Desc1",
                }

            };

            modelBuilder.Entity<News>().HasData(news);


        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TypeProduct> TypeProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<News> News { get; set; }
    }
}
