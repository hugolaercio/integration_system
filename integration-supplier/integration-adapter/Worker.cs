using integration_background;
using integration_background.core;
using integration_background.Infra;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace integration_adapter_client
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IRepository<FornecedorLegado> _repo;
        private readonly IMessageBrokerDomain _broker;

        public Worker(ILogger<Worker> logger, IRepository<FornecedorLegado> repo, IMessageBrokerDomain broker)
        {
            _logger = logger;
            _repo = repo;
            _broker = broker;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                ProcessamentoDoLegadoParaBroker processInt = new ProcessamentoDoLegadoParaBroker(_repo,_broker);
                processInt.Process();

                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
