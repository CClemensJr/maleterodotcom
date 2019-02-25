using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maletero.Data;
using Maletero.Models;
using Maletero.Models.Handler;
using Maletero.Models.Interfaces;
using Maletero.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Maletero
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        //support dependency injection
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //services.AddDbContext<MaleteroDbContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<MaleteroDbContext>(options =>
                                                     options.UseSqlServer(Configuration["ConnectionStrings:ProductionConnection"]));

            //services.AddDbContext<ApplicationDbContext>(options => 
            //                                            options.UseSqlServer(Configuration["ConnectionStrings:IdentityConnection"]));
            services.AddDbContext<ApplicationDbContext>(options =>
                                                        options.UseSqlServer(Configuration["ConnectionStrings:ProductionIdentityConnection"]));


            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("WashingtonStateOnly", policy => policy.Requirements.Add(new StateRequirement()));
            });

            //dependency injection
            services.AddScoped<IInventory, ProductManagement>();
            services.AddTransient<ProductManagement>();
            services.AddScoped<IAuthorizationHandler, StateRequirement>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes => 
            {
                routes.MapRoute(
                    name: "default", 
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
