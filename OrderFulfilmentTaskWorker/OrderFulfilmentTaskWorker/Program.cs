using AtlasEngine;
using AtlasEngine.ApiClient;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrderFulfilmentTaskWorker.Worker;

public class Program
{
    public static void Main(string[] args)
    {
        var hostBuilder = CreateHostBuilder(args);
        var host = hostBuilder.Build();

        host.Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {


        return Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, builder) =>
            {
                builder.
                    AddEnvironmentVariables()
                    .AddCommandLine(args)
                    .AddJsonFile("appsettings.json");
            })
            .ConfigureLogging((context, builder) =>
            {
                builder.AddConfiguration(context.Configuration.GetSection("Logging"));
                builder.AddDebug();
                builder.AddConsole();
            })
            .UseExternalTaskWorkers()
            .ConfigureServices((context, services) =>
            {
                services.Configure<ApiClientSettings>(context.Configuration.GetSection("ExternalTaskWorker"));
                services.AddScoped<AnalysePOHandler>(); 
            });
    }
}