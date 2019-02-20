using Camping.Model.ProductModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Camping.Data
{
    public class CampingDbContext:DbContext
    {
        public CampingDbContext(DbContextOptions<CampingDbContext> options) : base

           (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID =1,
                    Sku="",
                    Name="",
                    Price ="",
                    Description="",
                    Image=""

                },
                 new Product
                 {
                     ID = 1,
                     Sku = "",
                     Name = "",
                     Price = "",
                     Description = "",
                     Image = ""

                 },
                  new Product
                  {
                      ID = 1,
                      Sku = "",
                      Name = "",
                      Price = "",
                      Description = "",
                      Image = ""

                  },
                   new Product
                   {
                       ID = 1,
                       Sku = "",
                       Name = "",
                       Price = "",
                       Description = "",
                       Image = ""

                   },
                    new Product
                    {
                        ID = 1,
                        Sku = "",
                        Name = "",
                        Price = "",
                        Description = "",
                        Image = ""

                    },
                     new Product
                     {
                         ID = 1,
                         Sku = "",
                         Name = "",
                         Price = "",
                         Description = "",
                         Image = ""

                     },
                      new Product
                      {
                          ID = 2,
                          Sku = "",
                          Name = "",
                          Price = "",
                          Description = "",
                          Image = ""

                      },
                       new Product
                       {
                           ID = 1,
                           Sku = "",
                           Name = "",
                           Price = "",
                           Description = "",
                           Image = ""

                       },
                        new Product
                        {
                            ID = 1,
                            Sku = "",
                            Name = "",
                            Price = "",
                            Description = "",
                            Image = ""

                        },
                         new Product
                         {
                             ID = 1,
                             Sku = "",
                             Name = "",
                             Price = "",
                             Description = "",
                             Image = ""

                         },
        }
    }


}
