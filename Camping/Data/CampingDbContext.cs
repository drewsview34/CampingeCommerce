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
                    Sku = "BS6000",
                    Name = "BackPack",
                    Price = 30,
                    Description = "This is a backpack",
                    Image = "/Assets/backpack.jpg"

                },
                 new Product
                 {
                     ID = 2,
                     Sku = "BS6001",
                     Name = "Sleeping Gear",
                     Price = 80,
                     Description = "This is a sleeping bag",
                     Image = "/Assets/sleepingbag.jpg"

                 },
                  new Product
                  {
                      ID = 3,
                      Sku = "BS6002",
                      Name = "FlashLight",
                      Price = 30,
                      Description = "Can be used to help see",
                      Image = "/Assets/flashlight.jpg"

                  },
                   new Product
                   {
                       ID = 4,
                       Sku = "BS6003",
                       Name = "Lantern",
                       Price = 40,
                       Description = "Can be used to help see",
                       Image = "/Assets/lantern.jpg"

                   },
                    new Product
                    {
                        ID = 5,
                        Sku = "BS6004",
                        Name = "Gloves",
                        Price = 80,
                        Description = "A pair of gloves",
                        Image = "/Assets/gloves.png"

                    },
                     new Product
                     {
                         ID = 6,
                         Sku = "BS6005",
                         Name = "Rain shell",
                         Price = 20,
                         Description = "Water shedder",
                         Image = "/Assets/rainshell.jpg"

                     },
                      new Product
                      {
                          ID = 7,
                          Sku = "BS6006",
                          Name = "Map",
                          Price = 10,
                          Description = "luis and clarks map",
                          Image = "/Assets/map.jpg"

                      },
                       new Product
                       {
                           ID = 8,
                           Sku = "BS6007",
                           Name = "Flint and Steel",
                           Price = 10,
                           Description = "Fire starting kit",
                           Image = "/Assets/flint.jpg"

                       },
                        new Product
                        {
                            ID = 9,
                            Sku = "BS6008",
                            Name = "Hat",
                            Price = 50,
                            Description = "Baseball cap",
                            Image = "/Assets/hat.jpg"

                        },
                         new Product
                         {
                             ID = 10,
                             Sku = "BS6009",
                             Name = "Gps",
                             Price = 200,
                             Description = "Tracking device",
                             Image = "/Assets/gps.jpg"

                         }
                         );
        }

        public DbSet<Product> Inventory { get; set; }
    }
}   



