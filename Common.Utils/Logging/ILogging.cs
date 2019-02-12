using System;

namespace Logging
{
    public interface ILogging<out T> where T : class
    {
        void Critical(string message, params object[] args);
        void Critical(Exception e, string message, params object[] args);
        void Error(string message, params object[] args);
        void Error(Exception e, string message, params object[] args);
        void Warn(string message, params object[] args);
        void Warn(Exception e, string message, params object[] args);
        void Info(string message, params object[] args);
        void Info(Exception e, string message, params object[] args);
        void Debug(string message, params object[] args);
        void Debug(Exception e, string message, params object[] args);
    }
}
