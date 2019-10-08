using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Api_SNE.Extensions;
using Contracts;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NLog;

namespace ApiExpertAuto
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "\\nlog.config"));
            Configuration = configuration;
            Issuer = Configuration.GetSection("Security").GetSection("issuer").Value;
            SecretKey = Configuration.GetSection("Security").GetSection("secretKey").Value;
            Delai = Configuration.GetSection("Token").GetSection("Delai").Value;
        }

        public IConfiguration Configuration { get; }
        public static string Issuer = "";
        public static string SecretKey = "";
        public static string Delai = "";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.JwtBearerDefault(Configuration);

            services.ConfigureSqlServerContext(Configuration);
           

            services.AddSingleton<ILoggerManager, LoggerManager>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

           
                    //services.ConfigureSqlServerMikidiaContext(Configuration);
            services.ConfigureRepositoryWrapper();
            services.ConfigureClientService();
            services.AddScoped<ModelValidationAttribute>();

            
            //Swagger
            services.SwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerManager logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.ConfigureExceptionHandler(logger);
            //Authentification JWT
            app.UseAuthentication();

            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Expert Auto  API V1");
            });

            app.UseMvc();
        }
    }
}
