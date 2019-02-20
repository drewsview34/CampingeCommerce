﻿// <auto-generated />
using Camping.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Camping.Migrations
{
    [DbContext(typeof(CampingDbContext))]
    [Migration("20190220230207_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Camping.Model.ProductModel.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Sku");

                    b.HasKey("ID");

                    b.ToTable("Inventory");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "",
                            Image = "",
                            Name = "Tent",
                            Price = 90m,
                            Sku = "BS6-002"
                        },
                        new
                        {
                            ID = 2,
                            Description = "",
                            Image = "",
                            Name = "Sleeping Gear",
                            Price = 80m,
                            Sku = "BS6-003"
                        },
                        new
                        {
                            ID = 3,
                            Description = "",
                            Image = "",
                            Name = "FlashLight",
                            Price = 30m,
                            Sku = "BS6-004"
                        },
                        new
                        {
                            ID = 4,
                            Description = "",
                            Image = "",
                            Name = "lanterns",
                            Price = 40m,
                            Sku = "BS6-006"
                        },
                        new
                        {
                            ID = 5,
                            Description = "",
                            Image = "",
                            Name = "Gloves",
                            Price = 80m,
                            Sku = "BS6-007"
                        },
                        new
                        {
                            ID = 6,
                            Description = "",
                            Image = "",
                            Name = "Rain shell",
                            Price = 20m,
                            Sku = "BS6-008"
                        },
                        new
                        {
                            ID = 7,
                            Description = "",
                            Image = "",
                            Name = "map",
                            Price = 10m,
                            Sku = "bs6-009"
                        },
                        new
                        {
                            ID = 8,
                            Description = "",
                            Image = "",
                            Name = "lighter",
                            Price = 10m,
                            Sku = "BS6-000"
                        },
                        new
                        {
                            ID = 9,
                            Description = "",
                            Image = "",
                            Name = "Hat",
                            Price = 50m,
                            Sku = ""
                        },
                        new
                        {
                            ID = 10,
                            Description = "",
                            Image = "",
                            Name = "Gps",
                            Price = 200m,
                            Sku = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
