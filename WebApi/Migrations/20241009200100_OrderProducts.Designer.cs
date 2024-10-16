﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApi;

#nullable disable

namespace WebApiMigrations
{
    [DbContext(typeof(Context))]
    [Migration("20241009200100_OrderProducts")]
    partial class OrderProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Models.News", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea1c4ded-edf8-48c3-a9e5-e6b813673e33"),
                            Created = new DateTime(2024, 10, 29, 20, 0, 59, 975, DateTimeKind.Utc).AddTicks(4985),
                            Description = "Desc1",
                            Title = "Title1"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Sum")
                        .HasColumnType("numeric");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("329d94cc-9384-4b7d-82f3-e7b9849198a2"),
                            Sum = 1m,
                            UserId = new Guid("3d0c1708-d345-4a94-9033-cd608dbcf986")
                        });
                });

            modelBuilder.Entity("WebApi.Models.OrderProducts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<int>("ProductCount")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5922576e-1645-44bd-b46f-73dbc2767715"),
                            Count = 1,
                            Name = "Цифровой арт \"Далекое будущее\"",
                            Price = 5000m,
                            TypeId = new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10")
                        },
                        new
                        {
                            Id = new Guid("fc4cd567-52da-4590-ac58-04cc5a162a79"),
                            Count = 1,
                            Name = "Видеоурок \"Как сделать первый 3D дизайн\"",
                            Price = 2000m,
                            TypeId = new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10")
                        },
                        new
                        {
                            Id = new Guid("f7ab464f-bd8a-4007-95dd-a525041e98a3"),
                            Count = 1,
                            Name = "Курс \"Художник за месяц\"",
                            Price = 6000m,
                            TypeId = new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10")
                        },
                        new
                        {
                            Id = new Guid("4b03d3da-16b7-40ef-be7d-b7d3c9ec57e1"),
                            Count = 1,
                            Name = "Песня, сгенерированная нейросетью",
                            Price = 100m,
                            TypeId = new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10")
                        },
                        new
                        {
                            Id = new Guid("32d2d2aa-afed-4b7e-9ab6-6a1069da67e8"),
                            Count = 1,
                            Name = "Цифровой арт \"Цифровое искусство\"",
                            Price = 5000m,
                            TypeId = new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10")
                        },
                        new
                        {
                            Id = new Guid("244722fb-5822-488e-957d-63fbf2d124cb"),
                            Count = 1,
                            Name = "Видеоурок \"Песня \"Ромашки\" на гитаре\"",
                            Price = 2000m,
                            TypeId = new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10")
                        },
                        new
                        {
                            Id = new Guid("0ab5e34f-b0ce-48e7-add4-6b90e541188b"),
                            Count = 1,
                            Name = "Цифровой арт \"Красивый город\"",
                            Price = 5000m,
                            TypeId = new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10")
                        },
                        new
                        {
                            Id = new Guid("ca801d47-180c-4fc3-8fb0-b822e28047ab"),
                            Count = 1,
                            Name = "Реклама",
                            Price = 10000m,
                            TypeId = new Guid("02b1143a-7a7c-43a0-b701-cf0bdf18b59b")
                        },
                        new
                        {
                            Id = new Guid("3f3f0a3d-879e-4c70-9b67-244a198503ef"),
                            Count = 1,
                            Name = "Помощь с идеей для вашего проекта",
                            Price = 500m,
                            TypeId = new Guid("02b1143a-7a7c-43a0-b701-cf0bdf18b59b")
                        },
                        new
                        {
                            Id = new Guid("f8306c6c-b934-451d-9156-3da0c2f7fb5c"),
                            Count = 1,
                            Name = "Онлайн урок по рисованию",
                            Price = 1900m,
                            TypeId = new Guid("02b1143a-7a7c-43a0-b701-cf0bdf18b59b")
                        });
                });

            modelBuilder.Entity("WebApi.Models.TypeProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypeProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c75e38ae-d832-4ad0-a4ab-30a9f5371a10"),
                            Name = "Товар"
                        },
                        new
                        {
                            Id = new Guid("02b1143a-7a7c-43a0-b701-cf0bdf18b59b"),
                            Name = "Услуга"
                        });
                });

            modelBuilder.Entity("WebApi.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsClient")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsProvider")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3d0c1708-d345-4a94-9033-cd608dbcf986"),
                            Discount = 10m,
                            FIO = "Иванов Иван Иванович",
                            IsClient = true,
                            IsProvider = true
                        },
                        new
                        {
                            Id = new Guid("0dd1c72a-e674-4373-9423-df5de9d1a506"),
                            Discount = 0m,
                            FIO = "Петров Петр Петрович",
                            IsClient = true,
                            IsProvider = false
                        },
                        new
                        {
                            Id = new Guid("feb0569b-57ab-4b68-bb99-672522b32ade"),
                            Discount = 0m,
                            FIO = "Максимов Максим Максимович",
                            IsClient = false,
                            IsProvider = true
                        });
                });

            modelBuilder.Entity("WebApi.Models.Order", b =>
                {
                    b.HasOne("WebApi.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Models.OrderProducts", b =>
                {
                    b.HasOne("WebApi.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.HasOne("WebApi.Models.TypeProduct", "TypeProduct")
                        .WithMany("Products")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeProduct");
                });

            modelBuilder.Entity("WebApi.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("WebApi.Models.TypeProduct", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebApi.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
