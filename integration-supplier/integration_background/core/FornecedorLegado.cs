
namespace integration_background.core
{
    public class FornecedorLegado
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public bool Ativo { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }

        public FornecedorLegado(string nome, string email, string cnpj, bool ativo, string endereco, string numero)
        {
            Nome = nome;
            Email = email;
            Cnpj = cnpj;
            Ativo = ativo;
            Endereco = endereco;
            Numero = numero;
        }

    }
}
