using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

using System.Xml;

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
                    FIO = "Иванов Иван Иванович",
                    Discount = 10,
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    IsClient = true,
                    IsProvider = false,
                    FIO = "Петров Петр Петрович",
                    Discount = 0,
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    IsClient = false,
                    IsProvider = true,
                    FIO = "Максимов Максим Максимович",
                    Discount = 0,
                },

            };

            modelBuilder.Entity<User>().HasData(users);

            //ТОВАРЫ
            List<Product> products = new List<Product>()
            {
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 5000,
                    TypeId = typeProducts[0].Id,
                    Name = "Цифровой арт \"Далекое будущее\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 2000,
                    TypeId = typeProducts[0].Id,
                    Name = "Видеоурок \"Как сделать первый 3D дизайн\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 6000,
                    TypeId = typeProducts[0].Id,
                    Name = "Курс \"Художник за месяц\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 100,
                    TypeId = typeProducts[0].Id,
                    Name = "Песня, сгенерированная нейросетью"
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 5000,
                    TypeId = typeProducts[0].Id,
                    Name = "Цифровой арт \"Цифровое искусство\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 2000,
                    TypeId = typeProducts[0].Id,
                    Name = "Видеоурок \"Песня \"Ромашки\" на гитаре\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 5000,
                    TypeId = typeProducts[0].Id,
                    Name = "Цифровой арт \"Красивый город\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 10000,
                    TypeId = typeProducts[1].Id,
                    Name = "Реклама"
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 500,
                    TypeId = typeProducts[1].Id,
                    Name = "Помощь с идеей для вашего проекта"
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 1,
                    Price = 1900,
                    TypeId = typeProducts[1].Id,
                    Name = "Онлайн урок по рисованию"
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
                    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
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
