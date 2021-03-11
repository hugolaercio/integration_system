
using integration_infra.legacy;

namespace integration_background.Infra
{
    public interface IMessageBrokerDomain
    {
        bool SendMessage(FornecedorContrato fornecedor);
    }
}