﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApi;

#nullable disable

namespace WebApiMigrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("e27b1bb1-555e-4dde-bb6d-fd6e65bbacf8"),
                            Created = new DateTime(2024, 10, 16, 8, 50, 6, 208, DateTimeKind.Utc).AddTicks(4359),
                            Description = "Desc1",
                            Title = "Title1"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Sum")
                        .HasColumnType("numeric");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("458c8a33-8b85-48e3-8a45-35255ba26b00"),
                            Count = 1,
                            ProductId = new Guid("3a4d9b48-ed19-4578-bcb5-92418e08403a"),
                            Sum = 1m,
                            UserId = new Guid("fbf9d1e1-5773-4507-81ba-35ad787ed33d")
                        });
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
                            Id = new Guid("3a4d9b48-ed19-4578-bcb5-92418e08403a"),
                            Count = 1,
                            Name = "Цифровой арт \"Далекое будущее\"",
                            Price = 5000m,
                            TypeId = new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f")
                        },
                        new
                        {
                            Id = new Guid("3b21bf5f-9e8e-4d44-9694-9e6bdf552154"),
                            Count = 1,
                            Name = "Видеоурок \"Как сделать первый 3D дизайн\"",
                            Price = 2000m,
                            TypeId = new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f")
                        },
                        new
                        {
                            Id = new Guid("b25d5a5a-2155-4944-9455-b620d68c713b"),
                            Count = 1,
                            Name = "Курс \"Художник за месяц\"",
                            Price = 6000m,
                            TypeId = new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f")
                        },
                        new
                        {
                            Id = new Guid("96e495df-484f-419d-a3f0-f01171b0bf43"),
                            Count = 1,
                            Name = "Песня, сгенерированная нейросетью",
                            Price = 100m,
                            TypeId = new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f")
                        },
                        new
                        {
                            Id = new Guid("b7cc61d0-3bd5-4d41-8efd-1f8e63352b1c"),
                            Count = 1,
                            Name = "Цифровой арт \"Цифровое искусство\"",
                            Price = 5000m,
                            TypeId = new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f")
                        },
                        new
                        {
                            Id = new Guid("dada8280-b999-4fa7-bf76-88326b1bb056"),
                            Count = 1,
                            Name = "Видеоурок \"Песня \"Ромашки\" на гитаре\"",
                            Price = 2000m,
                            TypeId = new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f")
                        },
                        new
                        {
                            Id = new Guid("9bc91a43-4f0e-4db6-a7b2-dc75409d7644"),
                            Count = 1,
                            Name = "Цифровой арт \"Красивый город\"",
                            Price = 5000m,
                            TypeId = new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f")
                        },
                        new
                        {
                            Id = new Guid("239dc1f9-f6fa-4a25-a7c6-c2da45e34191"),
                            Count = 1,
                            Name = "Реклама",
                            Price = 10000m,
                            TypeId = new Guid("01b7d1d6-fa88-4fa5-85ae-3c54a6602fe2")
                        },
                        new
                        {
                            Id = new Guid("9e33e7c8-e0e3-44de-acda-dee3973232b7"),
                            Count = 1,
                            Name = "Помощь с идеей для вашего проекта",
                            Price = 500m,
                            TypeId = new Guid("01b7d1d6-fa88-4fa5-85ae-3c54a6602fe2")
                        },
                        new
                        {
                            Id = new Guid("6fd2001c-1772-461e-bfa5-a85c259448c6"),
                            Count = 1,
                            Name = "Онлайн урок по рисованию",
                            Price = 1900m,
                            TypeId = new Guid("01b7d1d6-fa88-4fa5-85ae-3c54a6602fe2")
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
                            Id = new Guid("6c62e675-b04d-4914-ae02-e69151b66a8f"),
                            Name = "Товар"
                        },
                        new
                        {
                            Id = new Guid("01b7d1d6-fa88-4fa5-85ae-3c54a6602fe2"),
                            Name = "Услуга"
                        });
                });

            modelBuilder.Entity("WebApi.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal?>("Discount")
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
                            Id = new Guid("fbf9d1e1-5773-4507-81ba-35ad787ed33d"),
                            Discount = 10m,
                            FIO = "Иванов Иван Иванович",
                            IsClient = true,
                            IsProvider = true
                        },
                        new
                        {
                            Id = new Guid("d01fe64d-c823-4b7a-948a-b30dd58a9043"),
                            Discount = 0m,
                            FIO = "Петров Петр Петрович",
                            IsClient = true,
                            IsProvider = false
                        },
                        new
                        {
                            Id = new Guid("90f537d4-c46b-4f4e-9978-9c1156fb2d30"),
                            Discount = 0m,
                            FIO = "Максимов Максим Максимович",
                            IsClient = false,
                            IsProvider = true
                        });
                });

            modelBuilder.Entity("WebApi.Models.Order", b =>
                {
                    b.HasOne("WebApi.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
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

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.Navigation("Orders");
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
