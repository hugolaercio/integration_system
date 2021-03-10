using System;
using System.Collections.Generic;

namespace integration_adapter.Infra
{
    public interface IRepository<T>
    {
        IEnumerable<T> List();
    }
}