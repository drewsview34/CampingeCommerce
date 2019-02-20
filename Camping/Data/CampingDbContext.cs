using Camping.Model.ProductModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Camping.Data
{
    public class CampingDbContext : DbContext
    {
        public CampingDbContext(DbContextOptions<CampingDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Sku = "BS6-002",
                    Name = "Tent",
                    Price = 90,
                    Description = "",
                    Image = ""

                },
                 new Product
                 {
                     ID = 2,
                     Sku = "BS6-003",
                     Name = "Sleeping Gear",
                     Price = 80,
                     Description = "",
                     Image = ""

                 },
                  new Product
                  {
                      ID = 3,
                      Sku = "BS6-004",
                      Name = "FlashLight",
                      Price = 30,
                      Description = "",
                      Image = ""

                  },
                   new Product
                   {
                       ID = 4,
                       Sku = "BS6-006",
                       Name = "lanterns",
                       Price = 40,
                       Description = "",
                       Image = ""

                   },
                    new Product
                    {
                        ID = 5,
                        Sku = "BS6-007",
                        Name = "Gloves",
                        Price = 80,
                        Description = "",
                        Image = ""

                    },
                     new Product
                     {
                         ID = 6,
                         Sku = "BS6-008",
                         Name = "Rain shell",
                         Price = 20,
                         Description = "",
                         Image = ""

                     },
                      new Product
                      {
                          ID = 7,
                          Sku = "bs6-009",
                          Name = "map",
                          Price = 10,
                          Description = "",
                          Image = ""

                      },
                       new Product
                       {
                           ID = 8,
                           Sku = "BS6-000",
                           Name = "lighter",
                           Price = 10,
                           Description = "",
                           Image = ""

                       },
                        new Product
                        {
                            ID = 9,
                            Sku = "",
                            Name = "Hat",
                            Price = 50,
                            Description = "",
                            Image = ""

                        },
                         new Product
                         {
                             ID = 10,
                             Sku = "",
                             Name = "Gps",
                             Price = 200,
                             Description = "",
                             Image = ""

                         }
                         );
        }

        public DbSet<Product> Inventory { get; set; }
    }
}   



