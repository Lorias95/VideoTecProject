using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebAppBD.Data;

[assembly: HostingStartup(typeof(WebAppBD.Areas.Identity.IdentityHostingStartup))]
namespace WebAppBD.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<VIDEOTECContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VIDEOTECContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<VIDEOTECContext>();
            });
        }
    }
}