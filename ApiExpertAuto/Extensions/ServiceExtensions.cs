using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Entities.Models;
using Swashbuckle.AspNetCore.Swagger;
using Contracts;
using Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ApiExpertAuto.IServices;
using ApiExpertAuto.Services;
using LoggerService;

namespace ApiExpertAuto
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration Configuration)
        {
            var connection = Configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            services.AddDbContext<DbExpertAutoContext>(options => options.UseSqlServer(connection)/*, ServiceLifetime.Transient*/);
        }

        //public static void ConfigureSqlServerMikidiaContext(this IServiceCollection services, IConfiguration Configuration)
        //{
        //    var connection = Configuration.GetSection("ConnectionStrings").GetSection("MikidiaConnection").Value;
        //    services.AddDbContext<EPT_MIKIDIAContext>(options => options.UseSqlServer(connection)/*, ServiceLifetime.Singleton*/);
        //}

        public static void SwaggerGen(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "BRANCHEMENT ABONNE  API V1", Version = "v1" });
            });
        }

        public static void JwtBearerDefault(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,

                    ValidIssuer = "http://localhost:5000",
                    ValidAudience = "http://localhost:5000",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("Security").GetSection("secretKey").Value))
                };
            });
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            //services.AddScoped<IMikidiaRepositoryWrapper, MikidiaRepositoryWrapper>();
        }

        public static void ConfigureClientService(this IServiceCollection services)
        {            
            services.AddTransient<IParametreConfigService, ParametreConfigService>();
            //services.AddTransient<IDemandeService, DemandeService>();
            //services.AddTransient<IDemandeCreatService, DemandeCreatService>();
            //services.AddTransient<ILoginService, LoginService>();
            //services.AddTransient<IChargementParametreService, ChargementParametreService>();            
            //services.AddTransient<IServiceCommun, ServiceCommun>();
            //services.AddTransient<ISynchronisationService, SynchronisationService>();
        }
    }
}
