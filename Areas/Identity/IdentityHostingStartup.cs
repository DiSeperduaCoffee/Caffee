using System;
using DiSeperduaCoffe.Areas.Identity.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DiSeperduaCoffe.Areas.Identity.IdentityHostingStartup))]
namespace DiSeperduaCoffe.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DiSeperduaCoffeeDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DiSeperduaCoffeeDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<DiSeperduaCoffeeDbContext>();
            });
        }
    }
}