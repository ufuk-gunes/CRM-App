using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MixCRM.Data.Abstract;
using MixCRM.Data.Concrete;
using MixCRM.Models;

namespace MixCRM
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
            services.AddMvc();

            services.AddDbContext<DataContext>(options =>
            {

                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                options.EnableSensitiveDataLogging(true);
            });

            //services.AddTransient<IDepartmanRepository, EfDepartmanRepository>();
            services.AddTransient<IGenericRepostory<Departman>, GenericRepository<Departman>>();
            services.AddTransient<IGenericRepostory<Firma>, GenericRepository<Firma>>();
            services.AddTransient<IGenericRepostory<Kategori>, GenericRepository<Kategori>>();
            services.AddTransient<IGenericRepostory<Urun>, GenericRepository<Urun>>();
            services.AddTransient<IGenericRepostory<Musteri>, GenericRepository<Musteri>>();
            services.AddTransient<IGenericRepostory<Personel>, GenericRepository<Personel>>();
            services.AddTransient<IGenericRepostory<Satis>, GenericRepository<Satis>>();
            services.AddTransient<IGenericRepostory<Stok>, GenericRepository<Stok>>();
            services.AddTransient<IGenericRepostory<Teklif>, GenericRepository<Teklif>>();


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
