using System.Threading.Tasks;

namespace integration_adapter.Infra
{
    public interface IMessageBrokerDomain
    {
        bool SendMessage(core.Fornecedor fornecedor);
    }
}