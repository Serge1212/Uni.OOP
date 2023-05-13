using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Uni.OOP.Interfaces;
using Uni.OOP.Repositories;
using Uni.OOP.Services;
using Uni.OOP.UI;

// Please make sure that you've established the sql connection to SQL Server before proceeding using this app.

var builder = new HostBuilder()
    .ConfigureServices(services =>
    {
        // Db connection.
        var connectionString = GetDbConnectionString();
        services.AddScoped<SqlConnection>(_ => new SqlConnection(connectionString));

        services.AddSingleton<IMenuHandler, MenuHandler>();

        // Repositories.
        services.AddScoped<IFeatureRepository, FeatureRepository>();
        services.AddScoped<ICarRepository, CarRepository>();
        // Services.
        services.AddScoped<IFeatureService, FeatureService>();
        services.AddScoped<ICarService, CarService>();
    }
);

var host = builder.Build();

var serviceScope = host.Services.CreateScope();

var services = serviceScope.ServiceProvider;

try
{
    var menuHandler = services.GetRequiredService<IMenuHandler>();
    menuHandler.DisplayMenu();
}
catch (Exception ex)
{
    Console.WriteLine($"Error occured: {ex.Message}: {ex.StackTrace}");
}

static string GetDbConnectionString()
{
    // Values are displayed as is on purpose to avoid excessive work while connection establishing.
    var server = "(localdb)\\mssqllocaldb";
    var database = "CarShop";
    var username = "dbusr";
    var password = "111111";
    var template = "Server={0}; Database={1};User Id={2};Password={3};pooling=true;Max Pool Size=100;";

    var conString = string.Format(template!,
        server,
        database,
        username,
        password);

    return conString;
}