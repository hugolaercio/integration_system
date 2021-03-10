
using integration_adapter.Infra;
using System.Collections.Generic;

namespace integration_adapter.core
{
    public class ProcessIntegration 
    {
        IRepository<FornecedorLegado> _repo;
        IMessageBrokerDomain _broker;

        public ProcessIntegration(IRepository<FornecedorLegado> repo, IMessageBrokerDomain broker)
        {
            _repo = repo;
            _broker = broker;
        }

        public void Process()
        {

            IEnumerable<FornecedorLegado> lista = _repo.List();

            foreach(var item in lista)
            {
                try
                {
                    Fornecedor fornec = new Fornecedor(item.Nome, item.Email, item.Cnpj);
                    Endereco end = new Endereco(item.Endereco, item.Numero, "", "", "", "", "");
                    fornec.Endereco = end;
                    bool valido = _broker.SendMessage(fornec);
                }
                catch
                {
                    //mecanismo de logger
                }
            }
        }
    }
}
