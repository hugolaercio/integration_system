using integration_background.config;
using integration_background.core;
using integration_background.Infra;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Configuration;
using System.Text;

public class FactoryRabbitMQ : IFactory
{

    private RabbitMQConfigurations _configuration;

    public FactoryRabbitMQ(RabbitMQConfigurations configuration)
    {
        _configuration = configuration;
    }

    public IConnectionFactory CreateFactory()
    {

        return new ConnectionFactory()
        {
            HostName = _configuration.HostName,
            Port = _configuration.Port,
            UserName = _configuration.UserName,
            Password = _configuration.Password
        };
    }
}