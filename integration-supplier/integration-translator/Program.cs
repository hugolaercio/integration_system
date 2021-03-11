using System;
using System.IO;
using System.Text;
using System.Threading;
using integration_translator.infra;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;


namespace integration_translator
{
    class Program
    {
        private static IConfiguration _configuration;
        private static readonly AutoResetEvent _waitHandle =
            new AutoResetEvent(false);

        static void Main()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile($"appsettings.json");
            _configuration = builder.Build();

            var rabbitMQConfigurations = new RabbitMQConfigurations();
            new ConfigureFromConfigurationOptions<RabbitMQConfigurations>(
                _configuration.GetSection("RabbitMQConfigurations"))
                    .Configure(rabbitMQConfigurations);
/*
            var factory = new ConnectionFactory()
            {
                HostName = rabbitMQConfigurations.HostName,
                Port = rabbitMQConfigurations.Port,
                UserName = rabbitMQConfigurations.UserName,
                Password = rabbitMQConfigurations.Password
            };*/


        }
    }
}
