
using Microsoft.Extensions.Configuration;
using integration_infra.legacy;
using integration_background.Infra;

namespace integration_background.core
{
    public class MessageMockBroker : IMessageBrokerDomain
    {

        private IConfiguration config;

        public MessageMockBroker(IConfiguration configuration)
        {
            config = configuration;
        }

        public bool SendMessage(FornecedorContrato fornecedor)
        {
            return true;
        }
    }
}
