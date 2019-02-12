using System;

namespace Logging
{
    public interface ILoggingFactory
    {
        ILogging<T> Get<T>() where T : class;

        ILogging<object> Get(Type type);
    }
}
