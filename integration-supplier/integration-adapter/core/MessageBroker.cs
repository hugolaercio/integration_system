
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using integration_adapter.Infra;

namespace integration_adapter.core
{
    public class MessageBroker : IMessageBrokerDomain
    {

        private IConfiguration config;

        public MessageBroker(IConfiguration configuration)
        {
            config = configuration;
        }

        public bool SendMessage(Fornecedor fornecedor)
        {
            return true;
        }

       /* public IEnumerable<FornecedorLegado> List()
        {

            using (SqlConnection conexao = new SqlConnection(
               config.GetConnectionString("BaseLegada")))
            {
                return conexao.Query<FornecedorLegado>(
                    "SELECT id, nome, cnpj, endereco, numero FROM dbo.Fornecedores");
            }
        }*/
    }
}
