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
    }
}
