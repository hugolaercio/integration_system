using integration_core.Validations;

namespace integration_core.DomainObjects
{
    public class Fornecedor : Entity, IAggregateRoot
    {
        public string Nome { get; private set; }
        public Email Email { get; private set; }
        public Cnpj Cnpj { get; private set; }
        public bool Excluido { get; private set; }
        public Endereco Endereco { get; private set; }

        // EF Relation
        protected Fornecedor() { }

        public Fornecedor(string nome, string email, string cnpj)
        {
            Nome = nome;
            Email = new Email(email);
            Cnpj = new Cnpj(cnpj);
            Excluido = false;

            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Cnpj.Numero}";
        }


        public void TrocarEmail(string email)
        {
            Email = new Email(email);
        }

        public void AtribuirEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do fornecedor não pode estar vazio");
            Validacoes.ValidarSeIgual(Cnpj.Numero, 0, "O campo CNPJ não pode ser 0");
            Validacoes.ValidarSeVazio(Email.Endereco, "O campo Email não pode ser vazio");
        }

    }
}