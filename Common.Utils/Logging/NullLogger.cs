using System;

namespace Logging
{
    public class NullLogger<T> : ILogging<T> where T : class
    {
        public void Critical(string message, params object[] args)
        {
            // does nothing as it's a null logger
        }

        public void Critical(Exception e, string message, params object[] args)
        {
            // does nothing as it's a null logger
        }

        public void Debug(string message, params object[] args)
        {
            // does nothing as it's a null logger
        }

        public void Debug(Exception e, string message, params object[] args)
        {
            // does nothing as it's a null logger
        }

        public void Error(string message, params object[] args)
        {
            // does nothing as it's a null logger
        }

        public void Error(Exception e, string message, params object[] args)
        {
            // does nothing as it's a null logger
        }

        public void Info(string message, params object[] args)
        {
            // does nothing as it's a null logger
        }

        public void Info(Exception e, string message, params object[] args)
        {
            // does nothing as it's a null logger
        }

        public void Warn(string message, params object[] args)
        {
            // does nothing as it's a null logger
        }

        public void Warn(Exception e, string message, params object[] args)
        {
            // does nothing as it's a null logger
        }
    }
}