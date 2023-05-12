using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = new HostBuilder()
    .ConfigureServices(services =>
    {
        // here goes entire app setup.
    }
);

var host = builder.Build();

var serviceScope = host.Services.CreateScope();

var services = serviceScope.ServiceProvider;

try
{
    Console.WriteLine("Here comes the fire!");
}
catch (Exception ex)
{
    Console.WriteLine($"Error occured: {ex.Message}: {ex.StackTrace}");
}