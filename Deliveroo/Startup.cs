using Deliveroo.Data;
using Deliveroo.Models;
using Deliveroo.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Deliveroo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            //services.AddDbContext<DeliverooContext>(options =>
            //        options.UseMySql(
            //            context.Configuration.GetConnectionString("DeliverooContextConnection"))); 
            services.AddDbContext<DeliverooContext>(options =>
                      options.UseMySql(Configuration.GetConnectionString("DefaultConnection"),
                      new MySqlServerVersion("7.3.21")
                      ));
            services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<DeliverooContext>();

            services.AddScoped<CategoryRepository>();

            services.AddScoped<MenuRepository>();

            services.AddScoped<MenuItemRepository>();

            services.AddScoped<CartRepository>();

            services.AddScoped<CartItemRepository>();

            services.AddScoped<OrderRepository>();

            services.AddScoped<RestaurantRepository>();

            services.AddScoped<ReviewRepository>();

            services.AddScoped<UserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
