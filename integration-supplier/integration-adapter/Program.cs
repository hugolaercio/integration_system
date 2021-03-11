using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using integration_background.Configuration;

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
                    //IConfiguration configuration = hostContext.Configuration;
                    //services.Configure<RabbitMQConfiguration>(configuration.GetSection(nameof(RabbitMQConfiguration)));

                    services.RegisterServices();

                    services.AddHostedService<Worker>();
                });
    }

}
