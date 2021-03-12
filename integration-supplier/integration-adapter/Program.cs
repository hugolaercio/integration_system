using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using integration_background.Configuration;
using integration_background.config;
using Microsoft.Extensions.Options;

namespace integration_adapter_client
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var rabbitMQConfigurations = new RabbitMQConfigurations();
                    new ConfigureFromConfigurationOptions<RabbitMQConfigurations>(
                        hostContext.Configuration.GetSection("RabbitMQConfigurations"))
                            .Configure(rabbitMQConfigurations);

                    services.AddMessageBusConfiguration(rabbitMQConfigurations);

                    services.RegisterServices();

                    services.AddHostedService<Worker>();
                });
    }

}
