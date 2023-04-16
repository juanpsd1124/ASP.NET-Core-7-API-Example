

using AspNetCoreRateLimit;
using Core.Interfaces;
using Infraestructure.Repositories;
using Infraestructure.UnitOfWork;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) =>
                services.AddCors(options =>
                {
                    options.AddPolicy("CorsPolicy", builder =>
                        builder.AllowAnyOrigin()   //WithOrigins("https://dominio.com")
                        .AllowAnyMethod()          //WithMethods("GET","POST")
                        .AllowAnyHeader());        //WithHeaders("accept","content-type")
                });

    public static void AddAplicacionServices(this IServiceCollection services)
    {
        //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        //services.AddScoped<IProductoRepository, ProductoRepository>();
        //services.AddScoped<IMarcaRepository, MarcaRepository>();
        //services.AddScoped<ICategoriaRepository, CategoriaRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }

    public static void ConfigureRateLimiting(this IServiceCollection services) 
    {
        services.AddMemoryCache();
        services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        services.AddInMemoryRateLimiting();

        services.Configure<IpRateLimitOptions>(options =>
            {
                options.EnableEndpointRateLimiting = true;
                options.StackBlockedRequests = false;
                options.HttpStatusCode = 429;
                options.RealIpHeader = "X-Real-IP";
                options.GeneralRules = new List<RateLimitRule>
                {
                    new RateLimitRule
                    {
                        Endpoint = "*",
                        Period = "10s",
                        Limit = 30
                    }
                };
            });
    }

    public static void ConfigureApiVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion( 1, 0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            //options.ApiVersionReader = new QueryStringApiVersionReader("ver"); //Configuracion para versionado mediante parametro o QueryString
            //options.ApiVersionReader = new HeaderApiVersionReader("X-Version"); //Configuracion para versionado mediante encabezado

            //Conbinacion de tecnicas de versionado
            options.ApiVersionReader = ApiVersionReader.Combine(
                new QueryStringApiVersionReader("ver"),
                new HeaderApiVersionReader("X-Version")
            );
            options.ReportApiVersions = true;
        });
    }


}