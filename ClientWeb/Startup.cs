using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientWeb.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClientWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //ModuleServiceConfig = Configuration.GetSection("ApiServiceBase").GetSection("Url").Value;
        }

        public IConfiguration Configuration { get; }
        public static string ApiWebBase = "";
        public static string TraitementService = "";
        public static int InactivityTimeBeforeReloading;
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddTransient<IConfigurationService, ConfigurationService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            ApiWebBase = Configuration.GetSection("ApiServiceBase").GetValue<string>("Url");
            //TraitementService = Configuration.GetSection("ApiServiceEtatCivil").GetValue<string>("Url");
            //
            InactivityTimeBeforeReloading = Configuration.GetSection("InactivityTimeBeforeReloading").GetValue<int>("Time");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

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
