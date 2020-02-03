using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShopNew.Main;
using IntroShopNew.Main.Repository;
using IntroShopNew.Main.Interfaces;
using IntroShopNew.Main.MockData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace IntroShopNew
{
    public class Startup
    {
        private IConfigurationRoot _dbConf;
        public Startup(IHostingEnvironment ENV)
        {
            _dbConf = new ConfigurationBuilder().SetBasePath(ENV.ContentRootPath).AddJsonFile("settings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContent>(options => options.UseSqlServer(_dbConf.GetConnectionString("DefaultConnection")));

            services.AddTransient<IAllPhones, PhoneRepository>();
            services.AddTransient<IVideocardCategory, CategoryRepository>();

            services.AddTransient<IAllVideocards, MockVideocards>();
            services.AddTransient<IVideoCardCategory, MockVideocardCategory>();

            services.AddTransient<IAllProcessors, MockProcessors>();
            services.AddTransient<IProcessorCategory, MockProcessorCategory>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();


            using (var scope = app.ApplicationServices.CreateScope())
            {
                DBContent content = scope.ServiceProvider.GetRequiredService<DBContent>();
                DBObjects.Initial(content);
            }
        }
    }
}
