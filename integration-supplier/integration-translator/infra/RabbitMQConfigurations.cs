using System;
using System.Collections.Generic;
using System.Text;

namespace integration_translator.infra
{
    public class RabbitMQConfigurations
    {
        public string HostName { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
