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
           .HasOne(x => x.User)
           .WithMany(x => x.Orders)
           .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<OrderProducts>()
             .HasOne(x => x.Order)
             .WithMany(x => x.OrderProducts)
             .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<OrderProducts>()
             .HasOne(x => x.Product)
             .WithMany(x => x.OrderProducts)
             .HasForeignKey(x => x.ProductId);

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
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Юриков Дмитрий Александрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Иванов Сергей Максимович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Петров Алексей Дмитриевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Сидоров Иван Сергеевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Морозов Андрей Николаевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Васильев Константин Петрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Козлов Максим Иванович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Новиков Дмитрий Александрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Соколов Сергей Дмитриевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Михайлов Иван Сергеевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Федоров Андрей Николаевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Попов Константин Петрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Лебедев Максим Иванович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Ковалев Дмитрий Александрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Ильин Сергей Дмитриевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Григорьев Иван Сергеевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Семенов Андрей Николаевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Павлов Константин Петрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Андреев Максим Иванович",
    Discount = 00
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Макаров Дмитрий Александрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Николаев Сергей Дмитриевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Орлов Иван Сергеевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Алексеев Андрей Николаевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Сергеев Константин Петрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Дмитриев Максим Иванович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Егоров Дмитрий Александрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Кузнецов Сергей Дмитриевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Борисов Иван Сергеевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Соловьев Андрей Николаевич",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Комаров Константин Петрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Белов Максим Иванович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = false,
    IsProvider = true,
    FIO = "Филиппов Дмитрий Александрович",
    Discount = 0
},
new()
{
    Id = Guid.NewGuid(),
    IsClient = true,
    IsProvider = false,
    FIO = "Матвеев Сергей Дмитриевич",
    Discount = 0
},
            };

            modelBuilder.Entity<User>().HasData(users);

            //ТОВАРЫ
            List<Product> products = new List<Product>()
            {
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 5000,
                    TypeId = typeProducts[0].Id,
                    Name = "Цифровой арт \"Далекое будущее\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 2000,
                    TypeId = typeProducts[0].Id,
                    Name = "Видеоурок \"Как сделать первый 3D дизайн\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 6000,
                    TypeId = typeProducts[0].Id,
                    Name = "Курс \"Художник за месяц\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 100,
                    TypeId = typeProducts[0].Id,
                    Name = "Песня, сгенерированная нейросетью"
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 5000,
                    TypeId = typeProducts[0].Id,
                    Name = "Цифровой арт \"Цифровое искусство\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 2000,
                    TypeId = typeProducts[0].Id,
                    Name = "Видеоурок \"Песня \"Ромашки\" на гитаре\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 5000,
                    TypeId = typeProducts[0].Id,
                    Name = "Цифровой арт \"Красивый город\""
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 10000,
                    TypeId = typeProducts[1].Id,
                    Name = "Реклама"
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 500,
                    TypeId = typeProducts[1].Id,
                    Name = "Помощь с идеей для вашего проекта"
                },
                new()
                {
                    Id= Guid.NewGuid(),
                    Count = 0,
                    Price = 1900,
                    TypeId = typeProducts[1].Id,
                    Name = "Онлайн урок по рисованию"
                },
                new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 3500,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Ночной город\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 2500,
    TypeId = typeProducts[0].Id,
    Name = "Видеоурок \"Основы 3D моделирования\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 4500,
    TypeId = typeProducts[0].Id,
    Name = "Курс \"Графика в игре\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 150,
    TypeId = typeProducts[0].Id,
    Name = "Песня, сгенерированная нейросетью \"Весна\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 4000,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Закат на пляже\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 6000,
    TypeId = typeProducts[0].Id,
    Name = "Курс \"3D анимация\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 2000,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Летний день\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 1500,
    TypeId = typeProducts[0].Id,
    Name = "Видеоурок \"Рисование в Photoshop\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 5000,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Зимний лес\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 0,
    Price = 3000,
    TypeId = typeProducts[0].Id,
    Name = "Видеоурок \"Рисование портретов\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 4000,
    TypeId = typeProducts[0].Id,
    Name = "Курс \"2D анимация\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 2500,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Городской пейзаж\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 3500,
    TypeId = typeProducts[0].Id,
    Name = "Видеоурок \"Рисование в Procreate\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 5000,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Пейзаж с водопадом\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 2000,
    TypeId = typeProducts[0].Id,
    Name = "Видеоурок \"Рисование в Illustrator\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 4500,
    TypeId = typeProducts[0].Id,
    Name = "Курс \"3D моделирование\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 3000,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Пейзаж с горами\""
},

new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 5000,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Пейзаж с озером\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 3000,
    TypeId = typeProducts[1].Id,
    Name = "Видеоурок \"Рисование в Sketchbook\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 4000,
    TypeId = typeProducts[1].Id,
    Name = "Курс \"2D игровая графика\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 2500,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Пейзаж с лесом\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 3500,
    TypeId = typeProducts[1].Id,
    Name = "Видеоурок \"Рисование в Affinity Designer\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 5000,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Пейзаж с морем\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 2000,
    TypeId = typeProducts[1].Id,
    Name = "Видеоурок \"Рисование в Krita\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 4500,
    TypeId = typeProducts[1].Id,
    Name = "Курс \"3D игровая графика\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 3000,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Пейзаж с пустыней\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 2500,
    TypeId = typeProducts[1].Id,
    Name = "Видеоурок \"Рисование в PaintTool SAI\""
},
new()
{
    Id = Guid.NewGuid(),
    Count = 1,
    Price = 5000,
    TypeId = typeProducts[0].Id,
    Name = "Цифровой арт \"Пейзаж с вулканом\""
}
            };

            modelBuilder.Entity<Product>().HasData(products);






            //ЗАКАЗЫ
            List<Order> orders = new List<Order>()
            {
                new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[0].Id
                },
                 new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[1].Id
                },
                  new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[2].Id
                },
                   new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[3].Id
                },
                    new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[4].Id
                },
                     new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[5].Id
                }, new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[6].Id
                }, new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[7].Id
                }, new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[8].Id
                }, new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[9].Id
                },
                     new()
                {
                    Id= Guid.NewGuid(),
                    Sum = 0,
                    UserId = users[10].Id
                }
            };

            modelBuilder.Entity<Order>().HasData(orders);

            List<OrderProducts> orderProducts = new List<OrderProducts>()
            {
                new()
                {
                    OrderId = orders[0].Id,
                    ProductId = products[0].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[0].Id,
                    ProductId = products[1].Id,
                    ProductCount = products[0].Count,
                },
                  new()
                {
                    OrderId = orders[0].Id,
                    ProductId = products[2].Id,
                    ProductCount = products[0].Count,
                },
                    new()
                {
                    OrderId = orders[1].Id,
                    ProductId = products[3].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[1].Id,
                    ProductId = products[4].Id,
                    ProductCount = products[0].Count,
                },
                     new()
                {
                    OrderId = orders[2].Id,
                    ProductId = products[5].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[2].Id,
                    ProductId = products[6].Id,
                    ProductCount = products[0].Count,
                },
                         new()
                {
                    OrderId = orders[3].Id,
                    ProductId = products[7].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[3].Id,
                    ProductId = products[8].Id,
                    ProductCount = products[0].Count,
                },
                         new()
                {
                    OrderId = orders[4].Id,
                    ProductId = products[9].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[4].Id,
                    ProductId = products[10].Id,
                    ProductCount = products[0].Count,
                },
                         new()
                {
                    OrderId = orders[5].Id,
                    ProductId = products[11].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[5].Id,
                    ProductId = products[12].Id,
                    ProductCount = products[0].Count,
                },
                         new()
                {
                    OrderId = orders[6].Id,
                    ProductId = products[13].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[6].Id,
                    ProductId = products[14].Id,
                    ProductCount = products[0].Count,
                },
                         new()
                {
                    OrderId = orders[7].Id,
                    ProductId = products[15].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[7].Id,
                    ProductId = products[16].Id,
                    ProductCount = products[0].Count,
                },
                         new()
                {
                    OrderId = orders[8].Id,
                    ProductId = products[17].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[8].Id,
                    ProductId = products[18].Id,
                    ProductCount = products[0].Count,
                },
                         new()
                {
                    OrderId = orders[9].Id,
                    ProductId = products[19].Id,
                    ProductCount = products[0].Count,
                },
                 new()
                {
                    OrderId = orders[9].Id,
                    ProductId = products[20].Id,
                    ProductCount = products[0].Count,
                },


            };



            List<News> news = new List<News>()
            {
                new()
{
    Id = Guid.NewGuid(),
    Title = "Выставка современного искусства 'Абстракция'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Выставка представляет работы современных художников, посвященные теме абстракции.",
},
new()
{
    Id = Guid.NewGuid(),
    Title = "Международный конкурс 'Живопись 2023'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Конкурс открыт для художников со всего мира. Прием работ до 15 октября.",
},
new()
{
    Id = Guid.NewGuid(),
    Title = "Выставка 'Искусство XX века'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Выставка посвящена искусству XX века, включая работы известных мастеров.",
},
new()
{
    Id = Guid.NewGuid(),
    Title = "Конкурс 'Молодое искусство'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Конкурс для молодых художников до 30 лет. Прием работ до 30 ноября.",
},
new()
{
    Id = Guid.NewGuid(),
    Title = "Выставка 'Фотография как искусство'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Выставка фотографий, демонстрирующих фотографию как самостоятельное искусство.",
},
new()
{
    Id = Guid.NewGuid(),
    Title = "Конкурс 'Графика и рисунки'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Конкурс посвящен графике и рисункам. Прием работ до 20 декабря.",
},
new()
{
    Id = Guid.NewGuid(),
    Title = "Выставка 'Искусство Востока'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Выставка работ художников из стран Востока, представляющих традиционное и современное искусство.",
},
new()
{
    Id = Guid.NewGuid(),
    Title = "Конкурс 'Скульптура и пластика'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Конкурс для скульпторов и художников, работающих в области пластики. Прием работ до 10 января.",
},
new()
{
    Id = Guid.NewGuid(),
    Title = "Выставка 'Искусство и технологии'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Выставка, демонстрирующая взаимодействие искусства и современных технологий.",
},
new()
{
    Id = Guid.NewGuid(),
    Title = "Конкурс 'Искусство для детей'",
    Created = DateTime.UtcNow.AddDays(Random.Shared.Next(31)),
    Description = "Конкурс для детских художников до 12 лет. Прием работ до 1 февраля.",
}

            };

            modelBuilder.Entity<News>().HasData(news);


        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TypeProduct> TypeProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
    }
}
