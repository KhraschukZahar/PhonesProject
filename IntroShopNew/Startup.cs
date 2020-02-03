using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShopNew.Main.Interfaces;
using IntroShopNew.Main.MockData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace IntroShopNew
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllPhones, MockPhones>();
            services.AddTransient<IPhoneCategory, MockCategory>();

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
        }
    }
}
