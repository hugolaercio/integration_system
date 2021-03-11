
using integration_background.Infra;
using integration_infra.legacy;
using Microsoft.Extensions.Configuration;


namespace integration_background.core
{
    public class MessageBroker : IMessageBrokerDomain
    {

        private IConfiguration config;

        public MessageBroker(IConfiguration configuration)
        {
            config = configuration;
        }

        public bool SendMessage(FornecedorContrato fornecedor)
        {
            return true;
        }
    }
}
