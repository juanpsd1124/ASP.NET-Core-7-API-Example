using API.Extensions;
using API.Helpers.Errors;
using AspNetCoreRateLimit;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(builder.Configuration)
                    .Enrich.FromLogContext()
                    .CreateLogger();

//builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
builder.Services.ConfigureRateLimiting();   

// Add services to the container.

builder.Services.ConfigureCors(); //Method added from Application service extensions
builder.Services.AddAplicacionServices();
builder.Services.ConfigureApiVersioning();
builder.Services.AddJwt(builder.Configuration);

builder.Services.AddControllers( options =>
{
    options.RespectBrowserAcceptHeader = true;  
    options.ReturnHttpNotAcceptable = true; //Envia error si el cliente solicita un formato no soportado
}).AddXmlSerializerFormatters();

//builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

builder.Services.AddDbContext<TiendaContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString);
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

app.UseIpRateLimiting();    

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{

    var services = scope.ServiceProvider;
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();
    try
    {
        var context = services.GetRequiredService<TiendaContext>();
        await context.Database.MigrateAsync();
        await TiendaContextSeed.SeedAsync(context, loggerFactory);
        await TiendaContextSeed.SeedRolesAsync(context, loggerFactory);
    }
    catch (Exception ex)
    {
        var logger_ = loggerFactory.CreateLogger<Program>();
        logger_.LogError(ex, "Ocurrio un error durante la migración");
    }
}


app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();    

app.UseAuthorization();

app.MapControllers();

app.Run();
