using integration_background.core;
using integration_background.Infra;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;

namespace integration_background.Configuration
{
    public static class DependencyInjectionConfig
    {

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IRepository<FornecedorLegado>, FornecedorLegadoRepository>();
        }
    }
}