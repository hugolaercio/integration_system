
namespace integration_infra.legacy
{
    public class FornecedorContrato
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public EnderecoContrato Endereco { get; set; }

        public FornecedorContrato(string nome, string email, string cnpj)
        {
            Nome = nome;
            Email = email;
            Cnpj = cnpj;
        }
    }
}
