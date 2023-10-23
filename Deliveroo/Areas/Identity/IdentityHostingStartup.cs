//using System;
//using Deliveroo.Areas.Identity.Data;
//using Deliveroo.Data;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;

//[assembly: HostingStartup(typeof(Deliveroo.Areas.Identity.IdentityHostingStartup))]
//namespace Deliveroo.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public void Configure(IWebHostBuilder builder)
//        {
//            builder.ConfigureServices((context, services) =>
//            {
//                //services.AddDbContext<DeliverooContext>(options =>
//                //    options.UseSqlServer(
//                //        context.Configuration.GetConnectionString("DeliverooContextConnection")));
//                services.AddDbContext<DeliverooContext>(options =>
//                       options.UseMySql(context.Configuration.GetConnectionString("DefaultConnection"),
//                      new MySqlServerVersion("7.3.21")
//                      ));
//                services.AddDefaultIdentity<DeliverooUser>(options => options.SignIn.RequireConfirmedAccount = true)
//                    .AddEntityFrameworkStores<DeliverooContext>();
//            });
//        }
//    }
//}