using integration_core.DomainObjects;
using System;
using Xunit;

namespace integration_core.tests
{
    public class FornecedorTests
    {
        [Fact(DisplayName = "Novo fornecedor V�lido")]
        [Trait("Categoria", "Fornecedor Trait Testes")]
        public void Fornecedor_NovoFornecedor_DeveEstarValido()
        {
            var fornecedor = new Fornecedor("Fornecedor 1 LTDA", "fornecedor1@fornec.com.br", "27865757000102");
            Assert.NotNull(fornecedor);
            //Assert.Equal(0, cliente.ValidationResult.Errors.Count);
        }

        [Fact(DisplayName = "Novo fornecedor Inv�lido")]
        [Trait("Categoria", "Fornecedor Trait Testes")]
        public void Fornecedor_NovoFornecedor_DeveEstarInvalidoPorCNPJ()
        {
            var exception =
                Assert.Throws<DomainException>(() => new Fornecedor("Fornecedor 1 LTDA", "fornecedor1@fornec.com.br", "11111111111111"));

            Assert.Equal("CNPJ inv�lido", exception.Message);
        }

        [Fact(DisplayName = "Novo fornecedor Inv�lido")]
        [Trait("Categoria", "Fornecedor Trait Testes")]
        public void Fornecedor_NovoFornecedor_DeveEstarInvalidoPorNomeVazio()
        {
            var exception =
                Assert.Throws<DomainException>(() => new Fornecedor("", "fornecedor1@fornec.com.br", "27865757000102"));

            Assert.Equal("O campo Nome do fornecedor n�o pode estar vazio", exception.Message);
        }

        [Fact(DisplayName = "Novo fornecedor Inv�lido")]
        [Trait("Categoria", "Fornecedor Trait Testes")]
        public void Fornecedor_NovoFornecedor_DeveEstarInvalidoPorEmailInvalido()
        {
            var exception =
                Assert.Throws<DomainException>(() => new Fornecedor("Fornecedor 1 LTDA", "fornecedor1fornec.com.br", "27865757000102"));

            Assert.Equal("E-mail inv�lido", exception.Message);
        }
    }
}
