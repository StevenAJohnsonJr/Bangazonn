﻿// <auto-generated />
using System;
using Bangazonn;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bangazonn.Migrations
{
    [DbContext(typeof(BangazonnDbContext))]
    [Migration("20230828233839_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bangazonn.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StatusUpdateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Userid")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderDate = new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 1,
                            StatusUpdateDate = new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Userid = 1
                        },
                        new
                        {
                            Id = 2,
                            OrderDate = new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 2,
                            StatusUpdateDate = new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Userid = 2
                        },
                        new
                        {
                            Id = 3,
                            OrderDate = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 3,
                            StatusUpdateDate = new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Userid = 3
                        },
                        new
                        {
                            Id = 4,
                            OrderDate = new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 4,
                            StatusUpdateDate = new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Userid = 4
                        },
                        new
                        {
                            Id = 5,
                            OrderDate = new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductId = 5,
                            StatusUpdateDate = new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Userid = 5
                        });
                });

            modelBuilder.Entity("Bangazonn.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Completed"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Not Completed"
                        });
                });

            modelBuilder.Entity("Bangazonn.Models.PaymentTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PaymentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cash"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Card"
                        });
                });

            modelBuilder.Entity("Bangazonn.Models.ProductCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kitchen"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Home"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Outdoors"
                        });
                });

            modelBuilder.Entity("Bangazonn.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Name = "iPhone 14",
                            Price = 1099
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Name = "The Godfather",
                            Price = 20
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Name = "Towerl Set",
                            Price = 15
                        },
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Silverware Set ",
                            Price = 100
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            Name = "lawn Mower",
                            Price = 255
                        });
                });

            modelBuilder.Entity("Bangazonn.Models.UserPayments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PaymentId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("UserPayments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PaymentId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            PaymentId = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            PaymentId = 3,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            PaymentId = 4,
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            PaymentId = 5,
                            UserId = 5
                        });
                });

            modelBuilder.Entity("Bangazonn.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isSeller")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_at = new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Trent Jones",
                            Username = "Trent3000",
                            isSeller = true
                        },
                        new
                        {
                            Id = 2,
                            Created_at = new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Jack James",
                            Username = "Jack9000",
                            isSeller = false
                        },
                        new
                        {
                            Id = 3,
                            Created_at = new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Barry Holmes",
                            Username = "Barcoder1500",
                            isSeller = true
                        },
                        new
                        {
                            Id = 4,
                            Created_at = new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Manny Marzone",
                            Username = "ZoneTyme5000",
                            isSeller = true
                        },
                        new
                        {
                            Id = 5,
                            Created_at = new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Travis Sharp",
                            Username = "Sharpx6",
                            isSeller = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
