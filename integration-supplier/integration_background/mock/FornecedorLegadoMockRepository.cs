
using integration_background.Infra;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;


namespace integration_background.core
{
    public class FornecedorLegadoMockRepository : IRepository<FornecedorLegado>
    {

        private IConfiguration config;

        public FornecedorLegadoMockRepository(IConfiguration configuration)
        {
            config = configuration;
        }

       public IEnumerable<FornecedorLegado> List()
        {
            IList<FornecedorLegado> lista = new List<FornecedorLegado>();
            lista.Add(new FornecedorLegado("Fornec1", "fornec1@fornec.com.br", "27865757000102", true, "Av paulista", "1000"));
            lista.Add(new FornecedorLegado("Fornec2", "fornec2@fornec.com.br", "12528708000107", true, "Av Ibirapuera", "55"));
            lista.Add(new FornecedorLegado("Fornec3", "fornec3@fornec.com.br", "11111111111111", true, "Rua alpha", "30"));
            lista.Add(new FornecedorLegado("Fornec4", "fornec4@fornec.com.br", "27865757000102", false, "Rua beta", ""));
            lista.Add(new FornecedorLegado("Fornec5", "fornec5@fornec.com.br", "27865757000322", true, "Av delta", "111"));
            lista.Add(new FornecedorLegado("Fornec6", "fornec6@fornec.com.br", "08364948000138", true, "Av dos trabalhadores", "74"));
            lista.Add(new FornecedorLegado("Fornec7", "fornec7@fornec.com.br", "12648266000124", true, "", ""));
            lista.Add(new FornecedorLegado("", "fornec8@fornec.com.br", "33050071000158", true, "Av brigadeiro luiz antonio", "120"));
            lista.Add(new FornecedorLegado("Fornec9", "", "09288252000132", true, "Av Cosme Deodato", "2"));
            lista.Add(new FornecedorLegado("Fornec10", "fornec10fornec.com.br", "", true, "Av Itaquera", "20"));

            return lista;
        }
    }
}
