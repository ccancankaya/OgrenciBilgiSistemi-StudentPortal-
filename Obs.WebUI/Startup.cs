using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Obs.Business.Abstract;
using Obs.Business.Concrete;
using Obs.DataAccess.Abstract;
using Obs.DataAccess.Concrete.EntityFramework;
using Obs.WebUI.Entities;

namespace Obs.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<IStudentDal, EfStudentDal>();
            services.AddDbContext<CustomIdentityDbContext>(options => options.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Initial Catalog = Obs; Integrated Security = True;"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
            }

            ).AddRoleManager<RoleManager<CustomIdentityRole>>().AddEntityFrameworkStores<CustomIdentityDbContext>().AddDefaultTokenProviders();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();           
            app.UseIdentity();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            //uygulama açıldığında hangi sayfa ile açılacağı seçilir
            routeBuilder.MapRoute("Default", "{controller=StudentAccount}/{action=Login}");
        }
    }
}
