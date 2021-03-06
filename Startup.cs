using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DiSeperduaCoffee.Data;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.AspNetCore.Identity;
using DiSeperduaCoffee.Models;

namespace DiSeperduaCoffee.Controllers

{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add service
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<DiSeperduaCoffeeDbContext>(option =>
            {
                var connectionString = Configuration.GetConnectionString("DiSeperduaCoffee");
                var serverVersion = new MariaDbServerVersion(new Version(10, 6, 4));
                option.UseMySql(connectionString, serverVersion);
                option.UseLazyLoadingProxies();
            });
            services
                  .AddDefaultIdentity<Pengguna>()
                  .AddRoles<IdentityRole>()
                  .AddEntityFrameworkStores<DiSeperduaCoffeeDbContext>()
                  .AddDefaultTokenProviders();
                  services.AddRazorPages();
        }
        // This method gets called by the runtime. Use this method to configure t
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change thisfor production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();

            });
        }
    }
}