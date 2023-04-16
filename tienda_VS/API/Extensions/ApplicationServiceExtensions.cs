

using Core.Interfaces;
using Infraestructure.Repositories;
using Infraestructure.UnitOfWork;
using Infrastructure.Repositories;
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



}