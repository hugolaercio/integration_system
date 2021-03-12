using Bogus;
using integration_background;
using integration_background.config;
using integration_background.core;
using integration_background.Infra;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace tests_integration_adapter
{
    public class ProcessoAdapter
    {
        [Fact]
        public void DeveriaProcessarAListaDoLegado()
        {
            // Arrange
            var funcionariolegadoRepo = new Mock<IRepository<FornecedorLegado>>();

            funcionariolegadoRepo.Setup(c => c.List())
            .Returns(ObterFornecedoresVariados(10, true));

            RabbitMQConfigurations config = new RabbitMQConfigurations();
            config.HostName = "172.28.112.1";
            config.Port = 5672;
            config.UserName = "admin";
            config.Password = "admin";
            FactoryRabbitMQ _factory = new FactoryRabbitMQ(config);
            MessageBroker _broker = new MessageBroker(_factory);


            //List<FornecedorLegado> lista = funcionariolegadoRepo.List();
            //var clienteService = new ClienteService(clienteRepo.Object, mediatr.Object);

            // Act
            //var clientes = clienteService.ObterTodosAtivos();

            // Assert 
            //clienteRepo.Verify(r => r.ObterTodos(), Times.Once);
            //Assert.True(clientes.Any());
            //Assert.False(clientes.Count(c => !c.Ativo) > 0);

            ProcessamentoDoLegadoParaBroker processInt = new ProcessamentoDoLegadoParaBroker(funcionariolegadoRepo.Object, _broker);
            processInt.Process();

        }

        public IEnumerable<FornecedorLegado> ObterFornecedoresVariados(int quantidade, bool ativo)
        {
            List<string> CNPJs = new List<string>();
            CNPJs.Add("12528708000107");
            CNPJs.Add("04128563000110");
            CNPJs.Add("10338320000100");
            CNPJs.Add("02217319000107");
            CNPJs.Add("17167396000169");
            CNPJs.Add("11111111111111");
            CNPJs.Add("71208516000174");
            CNPJs.Add("05878397000132");

            Random rnd = new Random();
            int key = rnd.Next(8);

            var fornecedores = new Faker<FornecedorLegado>("pt_BR")
                .CustomInstantiator(f => new FornecedorLegado(f.Company.CompanyName(),
                  f.Internet.Email(),
                  CNPJs[key],
                  f.Random.Bool(),
                  f.Address.StreetAddress(),
                  f.Address.Random.Number(0, 100).ToString()));

            return fornecedores.Generate(quantidade);
        }
    }
}
