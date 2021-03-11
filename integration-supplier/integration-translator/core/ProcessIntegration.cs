

namespace integration_background
{
    public class ProcessIntegration 
    {
       /* IRepository<FornecedorLegado> _repo;
        IMessageBrokerDomain _broker;*/

/*        public ProcessIntegration(IRepository<FornecedorLegado> repo, IMessageBrokerDomain broker)
        {
            _repo = repo;
            _broker = broker;
        }*/

       /* public void ProcessItem(FornecedorContrato item)
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
        }*/
    }
}
