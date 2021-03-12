using integration_background.core;
using integration_background.Infra;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RabbitMQ.Client;

namespace integration_background.config
{
    public static class DependencyInjectionRabbitMQ
    {
        public static void AddMessageBusConfiguration(this IServiceCollection services,
           RabbitMQConfigurations configuration)
        {

             // services.Configure<IdentitySettings>(Configuration.GetSection("Identity"))

            services.AddSingleton(configuration);

            //FactoryRabbitMQ fabrica = new FactoryRabbitMQ(rabbitMQConfigurations);

            services.AddTransient<IFactory, FactoryRabbitMQ>();
            //services.AddSingleton<new FactoryRabbitMQ(rabbitMQConfigurations).GetFactory()>();
            services.AddTransient<IMessageBrokerDomain, MessageBroker>();
        }
    }
}
