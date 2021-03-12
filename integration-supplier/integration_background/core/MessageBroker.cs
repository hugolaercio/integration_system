
using integration_background.Infra;
using integration_infra.legacy;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;

namespace integration_background.core
{
    public class MessageBroker : IMessageBrokerDomain
    {

        private IFactory _factorycreator;

        public MessageBroker(IFactory factorycreator)
        {
            _factorycreator = factorycreator;
        }

        public bool SendMessage(FornecedorContrato fornecedor)
        {

            try
            {
                var factory = _factorycreator.CreateFactory();
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "TestesASPNETCore",
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);

                    var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(fornecedor));

                    channel.BasicPublish(exchange: "",
                                         routingKey: "TestesASPNETCore",
                                         basicProperties: null,
                                         body: body);
                }
            }
            catch(Exception ex)
            {

            }
            return true;
        }
    }
}
