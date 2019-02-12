using System;

namespace Logging
{
    public class NullLoggingFactory : ILoggingFactory
    {
        public ILogging<T> Get<T>() where T : class
        {
            return new NullLogger<T>();
        }

        public ILogging<object> Get(Type type)
        {
            return new NullLogger<object>();
        }
    }
}
