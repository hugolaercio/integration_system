
namespace integration_adapter.core
{
    public class Fornecedor
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public Endereco Endereco { get; set; }

        public Fornecedor(string nome, string email, string cnpj)
        {
            Nome = nome;
            Email = email;
            Cnpj = cnpj;
        }
    }
}
