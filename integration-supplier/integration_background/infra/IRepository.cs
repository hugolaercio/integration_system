using System;
using System.Collections.Generic;

namespace integration_background.Infra
{
    public interface IRepository<T>
    {
        IEnumerable<T> List();
    }
}