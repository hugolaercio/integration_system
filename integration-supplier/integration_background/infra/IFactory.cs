using RabbitMQ.Client;
using System;
using System.Collections.Generic;

namespace integration_background.Infra
{
    public interface IFactory
    {
        IConnectionFactory CreateFactory();
    }
}