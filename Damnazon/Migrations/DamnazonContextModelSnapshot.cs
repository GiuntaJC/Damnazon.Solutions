﻿// <auto-generated />
using System;
using Damnazon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Damnazon.Migrations
{
    [DbContext(typeof(DamnazonContext))]
    partial class DamnazonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Damnazon.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryDescription");

                    b.Property<string>("CategoryName");

                    b.Property<string>("ThumbnailImage");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Shop Jeff Bezos financial assets!",
                            CategoryName = "Assets",
                            ThumbnailImage = "\\img\\assett2.jpg"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Shop Jeff Bezos properties!",
                            CategoryName = "Properties",
                            ThumbnailImage = "\\img\\properties.jpg"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Shop Jeff Bezos vehicles!",
                            CategoryName = "Vehicles",
                            ThumbnailImage = "\\img\\vehicles.jpg"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryDescription = "Shop Jeff Bezos personal items!",
                            CategoryName = "Items",
                            ThumbnailImage = "\\img\\items.jpg"
                        });
                });

            modelBuilder.Entity("Damnazon.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Damnazon.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Damnazon.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Image");

                    b.Property<bool>("IsDamnazonSlime");

                    b.Property<bool>("IsDamnazonsChoice");

                    b.Property<bool>("IsInStock");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductName");

                    b.Property<decimal>("ProductPrice");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Image = "\\img\\blueOrigin.jpg",
                            IsDamnazonSlime = true,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Blue Origin, LLC is an American privately funded aerospace manufacturer and sub-orbital spaceflight services company headquartered in Kent, Washington.",
                            ProductName = "Blue Origin",
                            ProductPrice = 20000000m
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Image = "\\img\\washingtonPost.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "The Washington Post is an ancient newspaper dating back to 1877, adapting and transforming to fit the modern era. Nowadays, the Post is primarily a popular online news source featuring reliant information and a touch of tradition.",
                            ProductName = "Washington Post",
                            ProductPrice = 250000000m
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Image = "\\img\\wholeFoods.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Whole Foods Market, Inc. is an American multinational supermarket chain headquartered in Austin, Texas, which sells products free from hydrogenated fats and artificial colors, flavors, and preservatives.",
                            ProductName = "Whole Foods",
                            ProductPrice = 14000000000m
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Image = "\\img\\seattleLakehouse.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "One of his most popular homes is this Seattle mansion, located less than a mile from one of Bill Gates's favorite houses.",
                            ProductName = "Seattle Lake House",
                            ProductPrice = 10000000m
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Image = "\\img\\largestHouseInDc.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "The gigantic mansion used to be a textile museum and features a bold, extravagant exterior perfect for a man of Bezos’ stature.",
                            ProductName = "Largest house in Washington D.C.",
                            ProductPrice = 23000000m
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Image = "\\img\\gulfstreamPrivateJet.jpg",
                            IsDamnazonSlime = true,
                            IsDamnazonsChoice = false,
                            IsInStock = false,
                            ProductDescription = "Gulfstream G-650ER one of the fastest in the world, but it’s also all decked out to resemble a Michelin-starred restaurant more than a plane.",
                            ProductName = "Gulfstream Private Jet",
                            ProductPrice = 65000000m
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            Image = "\\img\\hondaAccord.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "This was the first car purchase by Amazon boss, This 1997 Honda Accord  four-cylinder engine, air conditioning, AM/FM/cassette radio, automatic transmission, power locks and windows",
                            ProductName = "1997 Honda Accord",
                            ProductPrice = 4000m
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 4,
                            Image = "\\img\\clock.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "this clock is unique because it is designed to keep time for 10,000 years. Jeff Bezos invested in this in order to have the means to embody the abstract longevity of time itself",
                            ProductName = "10,000-Year Clock",
                            ProductPrice = 42000000m
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 4,
                            Image = "\\img\\watch.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Overly priced Rolex that once belonged to Jeff Bezos.",
                            ProductName = "Rolex",
                            ProductPrice = 200000m
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4,
                            Image = "\\img\\dog.png",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "The pooch's name is SpotMini. 55 pounds and 3ft tall.",
                            ProductName = "Robot Dog",
                            ProductPrice = 50000m
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1,
                            Image = "\\img\\amzonrobotics.png",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Originally Kiva Systems, the robotics company was renamed as Amazon Robotics after Amazon acquired it for $775 million in March 2012. The company uses package-carrying robots at logistic centres and warehouses of Amazon.",
                            ProductName = "Amazon Robotics",
                            ProductPrice = 750000000m
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 3,
                            Image = "\\img\\bugatti.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Jeff Bezos's favourite car. The Bugatti Veyron Mansory is a hypercar without limits. Take the unparalleled specs of the Veyron and unsparingly use top-scale leather and carbon fiber throughout out the body of the car.",
                            ProductName = "Bugatti Veyron Mansory",
                            ProductPrice = 4000000000m
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 3,
                            Image = "\\img\\lykan.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Lykan Hypersport is a Lebanese limited production sports car manufactured by W Motors, a United Arab Emirates based company, founded in 2012 in Lebanon with the collaboration of Lebanese and Italian engineers. It is the first sports car to be designed and produced indigenously in the Middle East.",
                            ProductName = "W Motors Lykan Hypersport",
                            ProductPrice = 4000000m
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 2,
                            Image = "\\img\\ny.png",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "A fancy 10,000 square feet apartment in New York’s upscale Central Park West area, Bezos owns three linked apartments that are spread over 10,000 square feet.",
                            ProductName = "NY Apartment",
                            ProductPrice = 17000000m
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 2,
                            Image = "\\img\\beverlyhills.png",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Spanish style mansion in Beverly Hills, California. According to a report by Business Insider, the seven-bedroom seven-bathroom home has a greenhouse, a sunken and lighted tennis court, a huge swimming pool, four fountains, and a six-car garage.",
                            ProductName = "Beverly Hills Home",
                            ProductPrice = 24000000m
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 4,
                            Image = "\\img\\goldcomb.jpg",
                            IsDamnazonSlime = false,
                            IsDamnazonsChoice = true,
                            IsInStock = false,
                            ProductDescription = "Used; Like New",
                            ProductName = "Gold Comb",
                            ProductPrice = 1000000m
                        });
                });

            modelBuilder.Entity("Damnazon.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Damnazon.Models.OrderDetail", b =>
                {
                    b.HasOne("Damnazon.Models.Order", "order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Damnazon.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Damnazon.Models.Product", b =>
                {
                    b.HasOne("Damnazon.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Damnazon.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Damnazon.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
