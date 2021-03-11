
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;
using integration_background.Infra;

namespace integration_background.core
{
    public class FornecedorLegadoRepository : IRepository<FornecedorLegado>
    {

        private IConfiguration config;

        public FornecedorLegadoRepository(IConfiguration configuration)
        {
            config = configuration;
        }

       public IEnumerable<FornecedorLegado> List()
        {

            using (SqlConnection conexao = new SqlConnection(
               config.GetConnectionString("BaseLegada")))
            {
                return conexao.Query<FornecedorLegado>(
                    "SELECT id, nome, cnpj, endereco, numero FROM dbo.Fornecedores");
            }
        }
    }
}
