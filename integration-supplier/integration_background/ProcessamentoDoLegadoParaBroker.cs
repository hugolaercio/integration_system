
using integration_background.core;
using integration_background.Infra;
using integration_infra.legacy;
using System.Collections.Generic;

namespace integration_background
{
    public class ProcessamentoDoLegadoParaBroker 
    {
        IRepository<FornecedorLegado> _repo;
        IMessageBrokerDomain _broker;

        public ProcessamentoDoLegadoParaBroker(IRepository<FornecedorLegado> repo, IMessageBrokerDomain broker)
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
                    FornecedorContrato fornec = new FornecedorContrato(item.Nome, item.Email, item.Cnpj);
                    EnderecoContrato end = new EnderecoContrato(item.Endereco, item.Numero, "", "", "", "", "");
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
