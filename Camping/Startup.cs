﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Camping.Data;
using Camping.Model.Interface;
using Camping.Model.Services;
using Camping.Models;
using Camping.Models.Handler;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Camping
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();

           
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<IInventory, InventoryManagementService>();

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            //IdentityDB
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:IdentityProductionConnection"]));
            //CampDb
            services.AddDbContext<CampingDbContext>(options =>
            options.UseSqlServer(Configuration["ConnectionStrings:ProductionConnection"]));
            //External Login Providers
            services.AddAuthentication()
             .AddFacebook(facebook =>
             {
                 facebook.AppId = Configuration["Authentication:Facebook:AppId"];
                 facebook.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
             });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("allowedEmailDomainsonly", policy => policy.Requirements.Add(new EmailAddressRequirment()));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseAuthentication();
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}



